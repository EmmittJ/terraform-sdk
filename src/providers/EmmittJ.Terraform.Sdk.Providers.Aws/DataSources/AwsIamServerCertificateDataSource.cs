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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The latest attribute.
    /// </summary>
    public TerraformValue<bool>? Latest
    {
        get => GetArgument<TerraformValue<bool>>("latest");
        set => SetArgument("latest", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? AsReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The path_prefix attribute.
    /// </summary>
    public TerraformValue<string>? PathPrefix
    {
        get => GetArgument<TerraformValue<string>>("path_prefix");
        set => SetArgument("path_prefix", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    public TerraformValue<string> CertificateBody
        => AsReference("certificate_body");

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformValue<string> CertificateChain
        => AsReference("certificate_chain");

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformValue<string> ExpirationDate
        => AsReference("expiration_date");

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string> Path
        => AsReference("path");

    /// <summary>
    /// The upload_date attribute.
    /// </summary>
    public TerraformValue<string> UploadDate
        => AsReference("upload_date");

}
