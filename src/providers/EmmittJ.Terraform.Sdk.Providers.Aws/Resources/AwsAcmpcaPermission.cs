using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_acmpca_permission resource.
/// </summary>
public class AwsAcmpcaPermission : TerraformResource
{
    public AwsAcmpcaPermission(string name) : base("aws_acmpca_permission", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("policy");
    }

    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    public HashSet<TerraformProperty<string>>? Actions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("actions");
        set => this.WithProperty("actions", value);
    }

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityArn is required")]
    public required TerraformProperty<string> CertificateAuthorityArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("certificate_authority_arn");
        set => this.WithProperty("certificate_authority_arn", value);
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
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformProperty<string> Principal
    {
        get => GetRequiredProperty<TerraformProperty<string>>("principal");
        set => this.WithProperty("principal", value);
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
    /// The source_account attribute.
    /// </summary>
    public TerraformProperty<string>? SourceAccount
    {
        get => GetProperty<TerraformProperty<string>>("source_account");
        set => this.WithProperty("source_account", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformExpression Policy => this["policy"];

}
