using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_opensearch_package_association resource.
/// </summary>
public class AwsOpensearchPackageAssociation : TerraformResource
{
    public AwsOpensearchPackageAssociation(string name) : base("aws_opensearch_package_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("reference_path");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name")?.Value;
        set => this.WithProperty("domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The package_id attribute.
    /// </summary>
    public string? PackageId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("package_id")?.Value;
        set => this.WithProperty("package_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The reference_path attribute.
    /// </summary>
    public TerraformExpression ReferencePath => this["reference_path"];

}
