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
    public TerraformProperty<string>? DomainId
    {
        get => GetProperty<TerraformProperty<string>>("domain_id");
        set => this.WithProperty("domain_id", value);
    }

    /// <summary>
    /// The managed attribute.
    /// </summary>
    public TerraformProperty<bool>? Managed
    {
        get => GetProperty<TerraformProperty<bool>>("managed");
        set => this.WithProperty("managed", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
