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
        this.WithOutput("description");
        this.WithOutput("members");
        this.WithOutput("visibility");
    }

    /// <summary>
    /// The display name for the administrative unit
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The object ID of the administrative unit
    /// </summary>
    public TerraformProperty<string>? ObjectId
    {
        get => GetProperty<TerraformProperty<string>>("object_id");
        set => this.WithProperty("object_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadAdministrativeUnitDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadAdministrativeUnitDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
