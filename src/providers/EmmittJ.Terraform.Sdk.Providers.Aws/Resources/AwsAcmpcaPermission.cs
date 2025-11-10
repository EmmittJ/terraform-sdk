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
        SetOutput("policy");
        SetOutput("actions");
        SetOutput("certificate_authority_arn");
        SetOutput("id");
        SetOutput("principal");
        SetOutput("region");
        SetOutput("source_account");
    }

    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    public HashSet<TerraformProperty<string>> Actions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("actions");
        set => SetProperty("actions", value);
    }

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityArn is required")]
    public required TerraformProperty<string> CertificateAuthorityArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_authority_arn");
        set => SetProperty("certificate_authority_arn", value);
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
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformProperty<string> Principal
    {
        get => GetRequiredOutput<TerraformProperty<string>>("principal");
        set => SetProperty("principal", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The source_account attribute.
    /// </summary>
    public TerraformProperty<string> SourceAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_account");
        set => SetProperty("source_account", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformExpression Policy => this["policy"];

}
