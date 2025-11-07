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
        this.DeclareOutput("policy");
    }

    /// <summary>
    /// The actions attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Actions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("actions");
        set => this.WithProperty("actions", value);
    }

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CertificateAuthorityArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_authority_arn");
        set => this.WithProperty("certificate_authority_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Principal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal");
        set => this.WithProperty("principal", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The source_account attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_account");
        set => this.WithProperty("source_account", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformExpression Policy => this["policy"];

}
