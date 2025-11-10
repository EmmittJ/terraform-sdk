using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAdministrativeUnitDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azuread_administrative_unit.
/// </summary>
public class AzureadAdministrativeUnitDataSource : TerraformDataSource
{
    public AzureadAdministrativeUnitDataSource(string name) : base("azuread_administrative_unit", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("members");
        SetOutput("visibility");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("object_id");
    }

    /// <summary>
    /// The display name for the administrative unit
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The object ID of the administrative unit
    /// </summary>
    public TerraformProperty<string> ObjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("object_id");
        set => SetProperty("object_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadAdministrativeUnitDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The description for the administrative unit
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// A list of object IDs of members who are be present in this administrative unit.
    /// </summary>
    public TerraformExpression Members => this["members"];

    /// <summary>
    /// Whether the administrative unit and its members are hidden or publicly viewable in the directory
    /// </summary>
    public TerraformExpression Visibility => this["visibility"];

}
