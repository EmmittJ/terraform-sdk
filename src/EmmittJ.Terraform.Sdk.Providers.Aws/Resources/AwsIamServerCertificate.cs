using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_server_certificate resource.
/// </summary>
public class AwsIamServerCertificate : TerraformResource
{
    public AwsIamServerCertificate(string name) : base("aws_iam_server_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("expiration");
        this.DeclareOutput("upload_date");
    }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    public string? CertificateBody
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_body")?.Value;
        set => this.WithProperty("certificate_body", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public string? CertificateChain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_chain")?.Value;
        set => this.WithProperty("certificate_chain", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public string? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix")?.Value;
        set => this.WithProperty("name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public string? Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path")?.Value;
        set => this.WithProperty("path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    public string? PrivateKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_key")?.Value;
        set => this.WithProperty("private_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformExpression Expiration => this["expiration"];

    /// <summary>
    /// The upload_date attribute.
    /// </summary>
    public TerraformExpression UploadDate => this["upload_date"];

}
