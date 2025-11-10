using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsIamServerCertificateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateBody is required")]
    public required TerraformProperty<string> CertificateBody
    {
        get => GetProperty<TerraformProperty<string>>("certificate_body");
        set => this.WithProperty("certificate_body", value);
    }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateChain
    {
        get => GetProperty<TerraformProperty<string>>("certificate_chain");
        set => this.WithProperty("certificate_chain", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => this.WithProperty("path", value);
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateKey is required")]
    public required TerraformProperty<string> PrivateKey
    {
        get => GetProperty<TerraformProperty<string>>("private_key");
        set => this.WithProperty("private_key", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsIamServerCertificateTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsIamServerCertificateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
