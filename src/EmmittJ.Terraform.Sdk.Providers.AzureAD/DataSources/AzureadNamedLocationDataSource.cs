using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

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
        this.DeclareOutput("country");
        this.DeclareOutput("ip");
        this.DeclareOutput("object_id");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
