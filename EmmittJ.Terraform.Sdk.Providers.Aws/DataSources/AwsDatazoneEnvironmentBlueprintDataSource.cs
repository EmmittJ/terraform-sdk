using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_datazone_environment_blueprint.
/// </summary>
public class AwsDatazoneEnvironmentBlueprintDataSource : TerraformDataSource
{
    public AwsDatazoneEnvironmentBlueprintDataSource(string name) : base("aws_datazone_environment_blueprint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("blueprint_provider");
        this.DeclareOutput("description");
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    public string? DomainId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_id")?.Value;
        set => this.WithProperty("domain_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed attribute.
    /// </summary>
    public bool? Managed
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("managed")?.Value;
        set => this.WithProperty("managed", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The blueprint_provider attribute.
    /// </summary>
    public TerraformExpression BlueprintProvider => this["blueprint_provider"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
