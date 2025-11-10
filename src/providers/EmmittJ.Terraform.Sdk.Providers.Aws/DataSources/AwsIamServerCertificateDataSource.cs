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
        SetOutput("arn");
        SetOutput("certificate_body");
        SetOutput("certificate_chain");
        SetOutput("expiration_date");
        SetOutput("path");
        SetOutput("upload_date");
        SetOutput("id");
        SetOutput("latest");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("path_prefix");
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
    /// The latest attribute.
    /// </summary>
    public TerraformProperty<bool> Latest
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("latest");
        set => SetProperty("latest", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// The path_prefix attribute.
    /// </summary>
    public TerraformProperty<string> PathPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("path_prefix");
        set => SetProperty("path_prefix", value);
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
