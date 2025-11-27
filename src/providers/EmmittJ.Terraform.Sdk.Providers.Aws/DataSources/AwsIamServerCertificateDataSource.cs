using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_server_certificate Terraform data source.
/// Retrieves information about a aws_iam_server_certificate.
/// </summary>
public partial class AwsIamServerCertificateDataSource(string name) : TerraformDataSource("aws_iam_server_certificate", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The latest attribute.
    /// </summary>
    public TerraformValue<bool>? Latest
    {
        get => new TerraformReference<bool>(this, "latest");
        set => SetArgument("latest", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The path_prefix attribute.
    /// </summary>
    public TerraformValue<string>? PathPrefix
    {
        get => new TerraformReference<string>(this, "path_prefix");
        set => SetArgument("path_prefix", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    public TerraformValue<string> CertificateBody
    {
        get => new TerraformReference<string>(this, "certificate_body");
    }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformValue<string> CertificateChain
    {
        get => new TerraformReference<string>(this, "certificate_chain");
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformValue<string> ExpirationDate
    {
        get => new TerraformReference<string>(this, "expiration_date");
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
    }

    /// <summary>
    /// The upload_date attribute.
    /// </summary>
    public TerraformValue<string> UploadDate
    {
        get => new TerraformReference<string>(this, "upload_date");
    }

}
