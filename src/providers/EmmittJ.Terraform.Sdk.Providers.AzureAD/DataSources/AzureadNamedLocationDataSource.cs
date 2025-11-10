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
        set => SetProperty("read", value);
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
        SetOutput("country");
        SetOutput("ip");
        SetOutput("object_id");
        SetOutput("display_name");
        SetOutput("id");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadNamedLocationDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
