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
    public string? EngineVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_version")?.Value;
        set => this.WithProperty("engine_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The package_description attribute.
    /// </summary>
    public string? PackageDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("package_description")?.Value;
        set => this.WithProperty("package_description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The package_name attribute.
    /// </summary>
    public string? PackageName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("package_name")?.Value;
        set => this.WithProperty("package_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The package_type attribute.
    /// </summary>
    public string? PackageType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("package_type")?.Value;
        set => this.WithProperty("package_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
