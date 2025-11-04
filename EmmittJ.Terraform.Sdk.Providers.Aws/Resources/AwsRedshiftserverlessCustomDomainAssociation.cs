using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshiftserverless_custom_domain_association resource.
/// </summary>
public class AwsRedshiftserverlessCustomDomainAssociation : TerraformResource
{
    public AwsRedshiftserverlessCustomDomainAssociation(string name) : base("aws_redshiftserverless_custom_domain_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("custom_domain_certificate_expiry_time");
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The custom_domain_certificate_arn attribute.
    /// </summary>
    public string? CustomDomainCertificateArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_domain_certificate_arn")?.Value;
        set => this.WithProperty("custom_domain_certificate_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_domain_name attribute.
    /// </summary>
    public string? CustomDomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_domain_name")?.Value;
        set => this.WithProperty("custom_domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The workgroup_name attribute.
    /// </summary>
    public string? WorkgroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workgroup_name")?.Value;
        set => this.WithProperty("workgroup_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_domain_certificate_expiry_time attribute.
    /// </summary>
    public TerraformExpression CustomDomainCertificateExpiryTime => this["custom_domain_certificate_expiry_time"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
