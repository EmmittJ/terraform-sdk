using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_administrative_unit resource.
/// </summary>
public class AzureadAdministrativeUnit : TerraformResource
{
    public AzureadAdministrativeUnit(string name) : base("azuread_administrative_unit", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("object_id");
    }

    /// <summary>
    /// The description for the administrative unit
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display name for the administrative unit
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether the administrative unit and its members are hidden or publicly viewable in the directory
    /// </summary>
    public bool? HiddenMembershipEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("hidden_membership_enabled")?.Value;
        set => this.WithProperty("hidden_membership_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A set of object IDs of members who should be present in this administrative unit. Supported object types are Users or Groups
    /// </summary>
    public HashSet<string>? Members
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("members")?.Value;
        set => this.WithProperty("members", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// If `true`, will return an error if an existing administrative unit is found with the same name
    /// </summary>
    public bool? PreventDuplicateNames
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("prevent_duplicate_names")?.Value;
        set => this.WithProperty("prevent_duplicate_names", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The object ID of the administrative unit
    /// </summary>
    public TerraformExpression ObjectId => this["object_id"];

}
