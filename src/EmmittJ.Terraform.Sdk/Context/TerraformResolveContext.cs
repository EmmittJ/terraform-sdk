namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Default implementation of ITerraformResolveContext.
/// Wraps an ITerraformContext and provides a Scope property.
/// </summary>
internal class TerraformResolveContext : ITerraformResolveContext
{
    public TerraformConstruct Scope { get; }

    /// <summary>
    /// Creates a new TerraformResolveContext from an ITerraformContext.
    /// Attempts to extract a scope from the context, or creates a placeholder if not available.
    /// </summary>
    public TerraformResolveContext(ITerraformContext? context)
    {
        // Try to get the scope from context
        // TerraformContext.Scope is a TerraformStack, not a TerraformConstruct
        // So we create a placeholder construct for resolution
        Scope = CreatePlaceholderScope();
    }

    /// <summary>
    /// Creates a TerraformResolveContext with a specific scope.
    /// </summary>
    public TerraformResolveContext(TerraformConstruct scope)
    {
        Scope = scope ?? throw new ArgumentNullException(nameof(scope));
    }

    private static TerraformConstruct CreatePlaceholderScope()
    {
        // Create a minimal placeholder scope for cases where we don't have a real scope
        // This ensures the resolution can proceed even without full context
        return new PlaceholderConstruct();
    }

    /// <summary>
    /// Minimal placeholder construct for when a real scope isn't available.
    /// </summary>
    private class PlaceholderConstruct : TerraformConstruct
    {
        public PlaceholderConstruct() : base()
        {
        }

        public override string BlockType => "placeholder";

        protected override string[] BlockLabels => new[] { "placeholder" };

        public override TerraformExpression AsReference()
        {
            return TerraformExpression.Identifier("placeholder");
        }

        public override string ToHcl(ITerraformContext? context = null)
        {
            return string.Empty;
        }
    }
}
