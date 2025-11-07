using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_opensearch_package resource.
/// </summary>
public class AwsOpensearchPackage : TerraformResource
{
    public AwsOpensearchPackage(string name) : base("aws_opensearch_package", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("available_package_version");
        this.DeclareOutput("package_id");
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string>? EngineVersion
    {
        get => GetProperty<TerraformProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
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
    /// The package_description attribute.
    /// </summary>
    public TerraformProperty<string>? PackageDescription
    {
        get => GetProperty<TerraformProperty<string>>("package_description");
        set => this.WithProperty("package_description", value);
    }

    /// <summary>
    /// The package_name attribute.
    /// </summary>
    public TerraformProperty<string>? PackageName
    {
        get => GetProperty<TerraformProperty<string>>("package_name");
        set => this.WithProperty("package_name", value);
    }

    /// <summary>
    /// The package_type attribute.
    /// </summary>
    public TerraformProperty<string>? PackageType
    {
        get => GetProperty<TerraformProperty<string>>("package_type");
        set => this.WithProperty("package_type", value);
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
    /// The available_package_version attribute.
    /// </summary>
    public TerraformExpression AvailablePackageVersion => this["available_package_version"];

    /// <summary>
    /// The package_id attribute.
    /// </summary>
    public TerraformExpression PackageId => this["package_id"];

}
