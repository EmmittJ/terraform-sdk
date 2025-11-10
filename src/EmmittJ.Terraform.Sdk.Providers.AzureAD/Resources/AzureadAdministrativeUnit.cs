using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAdministrativeUnitTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name for the administrative unit
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Whether the administrative unit and its members are hidden or publicly viewable in the directory
    /// </summary>
    public TerraformProperty<bool>? HiddenMembershipEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("hidden_membership_enabled");
        set => this.WithProperty("hidden_membership_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// A set of object IDs of members who should be present in this administrative unit. Supported object types are Users or Groups
    /// </summary>
    public HashSet<TerraformProperty<string>>? Members
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("members");
        set => this.WithProperty("members", value);
    }

    /// <summary>
    /// If `true`, will return an error if an existing administrative unit is found with the same name
    /// </summary>
    public TerraformProperty<bool>? PreventDuplicateNames
    {
        get => GetProperty<TerraformProperty<bool>>("prevent_duplicate_names");
        set => this.WithProperty("prevent_duplicate_names", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadAdministrativeUnitTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadAdministrativeUnitTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The object ID of the administrative unit
    /// </summary>
    public TerraformExpression ObjectId => this["object_id"];

}
