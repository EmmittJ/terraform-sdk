namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Provides extension methods for indexed access to Terraform list/set blocks.
/// </summary>
public static class TerraformListExtensions
{
    /// <summary>
    /// Creates an indexed reference to a property within a list/set block element.
    /// </summary>
    /// <typeparam name="TBlock">The block element type.</typeparam>
    /// <typeparam name="TProperty">The property type being accessed.</typeparam>
    /// <param name="list">The list property (must have been assigned to a parent via a property setter).</param>
    /// <param name="index">The index into the list.</param>
    /// <param name="propertySelector">A function that selects the property from the block type.</param>
    /// <returns>A <see cref="TerraformValue{T}"/> that resolves to the indexed property reference.</returns>
    /// <remarks>
    /// <para>
    /// This method enables type-safe indexed access to nested block properties. The property selector
    /// receives a dummy instance of the block type to extract the property name, then builds
    /// the correct Terraform reference path.
    /// </para>
    /// <para>
    /// The list must have been assigned to a parent resource via a property setter (e.g., <c>containerApp.Ingress = [...]</c>)
    /// so that the parent and property name are tracked automatically.
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// var containerApp = new AzurermContainerApp("app")
    /// {
    ///     Ingress = [new() { TargetPort = 8080, ExternalEnabled = true, ... }]
    /// };
    ///
    /// // Access ingress[0].fqdn - returns TerraformValue&lt;string&gt; resolving to:
    /// // azurerm_container_app.app.ingress[0].fqdn
    /// var fqdn = containerApp.Ingress.Index(0, m => m.Fqdn);
    /// </code>
    /// </example>
    public static TerraformValue<TProperty> Index<TBlock, TProperty>(
        this TerraformList<TBlock>? list,
        int index,
        Func<TBlock, TerraformValue<TProperty>> propertySelector)
        where TBlock : TerraformBlock
    {
        ArgumentNullException.ThrowIfNull(list);
        ArgumentNullException.ThrowIfNull(propertySelector);

        var parent = list.ParentBlock;
        var listAttributeName = list.ParentAttributeName;

        if (parent is null || listAttributeName is null)
        {
            throw new InvalidOperationException(
                "Cannot create indexed reference: the list does not have a parent block or attribute name. " +
                "Make sure the list was assigned via a property setter (e.g., resource.Ingress = [...]).");
        }

        // Create an uninitialized dummy block to extract the attribute name via the selector
        var dummyBlock = (TBlock)System.Runtime.CompilerServices.RuntimeHelpers.GetUninitializedObject(typeof(TBlock));
        var reference = propertySelector(dummyBlock);

        // The reference contains the attribute name we need
        if (reference is not TerraformReference<TProperty> terraformRef)
        {
            throw new InvalidOperationException(
                $"Property selector must return a TerraformReference (a getter property). Got {reference.GetType().Name} instead.");
        }

        if (terraformRef.ParentAttributeName is not { } attributeName)
        {
            throw new InvalidOperationException(
                "Cannot create indexed reference: the selected property does not have a valid attribute name.");
        }

        return TerraformValue<TProperty>.Lazy(ctx =>
        {
            var expr = parent.AsReference().Index(listAttributeName, index).Member(attributeName);
            return [expr];
        });
    }
}
