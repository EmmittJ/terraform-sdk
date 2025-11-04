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
    public HashSet<string>? Actions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("actions")?.Value;
        set => this.WithProperty("actions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    public string? CertificateAuthorityArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_authority_arn")?.Value;
        set => this.WithProperty("certificate_authority_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The principal attribute.
    /// </summary>
    public string? Principal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal")?.Value;
        set => this.WithProperty("principal", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_account attribute.
    /// </summary>
    public string? SourceAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_account")?.Value;
        set => this.WithProperty("source_account", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformExpression Policy => this["policy"];

}
