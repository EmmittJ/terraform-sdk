using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_rds_certificate Terraform data source.
/// Retrieves information about a aws_rds_certificate.
/// </summary>
public partial class AwsRdsCertificateDataSource(string name) : TerraformDataSource("aws_rds_certificate", name)
{
    /// <summary>
    /// The default_for_new_launches attribute.
    /// </summary>
    public TerraformValue<bool>? DefaultForNewLaunches
    {
        get => GetArgument<TerraformValue<bool>>("default_for_new_launches");
        set => SetArgument("default_for_new_launches", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The latest_valid_till attribute.
    /// </summary>
    public TerraformValue<bool>? LatestValidTill
    {
        get => GetArgument<TerraformValue<bool>>("latest_valid_till");
        set => SetArgument("latest_valid_till", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The certificate_type attribute.
    /// </summary>
    public TerraformValue<string> CertificateType
        => AsReference("certificate_type");

    /// <summary>
    /// The customer_override attribute.
    /// </summary>
    public TerraformValue<bool> CustomerOverride
        => AsReference("customer_override");

    /// <summary>
    /// The customer_override_valid_till attribute.
    /// </summary>
    public TerraformValue<string> CustomerOverrideValidTill
        => AsReference("customer_override_valid_till");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => AsReference("thumbprint");

    /// <summary>
    /// The valid_from attribute.
    /// </summary>
    public TerraformValue<string> ValidFrom
        => AsReference("valid_from");

    /// <summary>
    /// The valid_till attribute.
    /// </summary>
    public TerraformValue<string> ValidTill
        => AsReference("valid_till");

}
