using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_server_certificate.
/// </summary>
public class AwsIamServerCertificateDataSource : TerraformDataSource
{
    public AwsIamServerCertificateDataSource(string name) : base("aws_iam_server_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("certificate_body");
        this.WithOutput("certificate_chain");
        this.WithOutput("expiration_date");
        this.WithOutput("path");
        this.WithOutput("upload_date");
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
    /// The latest attribute.
    /// </summary>
    public TerraformProperty<bool>? Latest
    {
        get => GetProperty<TerraformProperty<bool>>("latest");
        set => this.WithProperty("latest", value);
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
    /// The path_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? PathPrefix
    {
        get => GetProperty<TerraformProperty<string>>("path_prefix");
        set => this.WithProperty("path_prefix", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    public TerraformExpression CertificateBody => this["certificate_body"];

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformExpression CertificateChain => this["certificate_chain"];

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformExpression ExpirationDate => this["expiration_date"];

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformExpression Path => this["path"];

    /// <summary>
    /// The upload_date attribute.
    /// </summary>
    public TerraformExpression UploadDate => this["upload_date"];

}
