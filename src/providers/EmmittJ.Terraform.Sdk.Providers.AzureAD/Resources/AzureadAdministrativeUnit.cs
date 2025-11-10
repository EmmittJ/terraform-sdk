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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("object_id");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("hidden_membership_enabled");
        SetOutput("id");
        SetOutput("members");
        SetOutput("prevent_duplicate_names");
    }

    /// <summary>
    /// The description for the administrative unit
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display name for the administrative unit
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Whether the administrative unit and its members are hidden or publicly viewable in the directory
    /// </summary>
    public TerraformProperty<bool> HiddenMembershipEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("hidden_membership_enabled");
        set => SetProperty("hidden_membership_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// A set of object IDs of members who should be present in this administrative unit. Supported object types are Users or Groups
    /// </summary>
    public HashSet<TerraformProperty<string>> Members
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("members");
        set => SetProperty("members", value);
    }

    /// <summary>
    /// If `true`, will return an error if an existing administrative unit is found with the same name
    /// </summary>
    public TerraformProperty<bool> PreventDuplicateNames
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("prevent_duplicate_names");
        set => SetProperty("prevent_duplicate_names", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadAdministrativeUnitTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The object ID of the administrative unit
    /// </summary>
    public TerraformExpression ObjectId => this["object_id"];

}
