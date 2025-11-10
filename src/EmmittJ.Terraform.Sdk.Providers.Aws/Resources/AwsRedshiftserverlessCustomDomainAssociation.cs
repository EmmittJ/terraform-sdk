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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomDomainCertificateArn is required")]
    public required TerraformProperty<string> CustomDomainCertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("custom_domain_certificate_arn");
        set => this.WithProperty("custom_domain_certificate_arn", value);
    }

    /// <summary>
    /// The custom_domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomDomainName is required")]
    public required TerraformProperty<string> CustomDomainName
    {
        get => GetProperty<TerraformProperty<string>>("custom_domain_name");
        set => this.WithProperty("custom_domain_name", value);
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
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    public required TerraformProperty<string> WorkgroupName
    {
        get => GetProperty<TerraformProperty<string>>("workgroup_name");
        set => this.WithProperty("workgroup_name", value);
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
