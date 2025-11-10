using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadNamedLocationDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azuread_named_location.
/// </summary>
public class AzureadNamedLocationDataSource : TerraformDataSource
{
    public AzureadNamedLocationDataSource(string name) : base("azuread_named_location", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("country");
        this.WithOutput("ip");
        this.WithOutput("object_id");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadNamedLocationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadNamedLocationDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The country attribute.
    /// </summary>
    public TerraformExpression Country => this["country"];

    /// <summary>
    /// The ip attribute.
    /// </summary>
    public TerraformExpression Ip => this["ip"];

    /// <summary>
    /// The object ID of the named location
    /// </summary>
    public TerraformExpression ObjectId => this["object_id"];

}
