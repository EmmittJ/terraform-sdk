using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_licensemanager_received_license Terraform data source.
/// Retrieves information about a aws_licensemanager_received_license.
/// </summary>
public partial class AwsLicensemanagerReceivedLicenseDataSource(string name) : TerraformDataSource("aws_licensemanager_received_license", name)
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
    /// The license_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseArn is required")]
    public required TerraformValue<string> LicenseArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("license_arn");
        set => SetArgument("license_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The beneficiary attribute.
    /// </summary>
    public TerraformValue<string> Beneficiary
        => AsReference("beneficiary");

    /// <summary>
    /// The consumption_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConsumptionConfiguration
        => AsReference("consumption_configuration");

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The entitlements attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Entitlements
        => AsReference("entitlements");

    /// <summary>
    /// The home_region attribute.
    /// </summary>
    public TerraformValue<string> HomeRegion
        => AsReference("home_region");

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Issuer
        => AsReference("issuer");

    /// <summary>
    /// The license_metadata attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> LicenseMetadata
        => AsReference("license_metadata");

    /// <summary>
    /// The license_name attribute.
    /// </summary>
    public TerraformValue<string> LicenseName
        => AsReference("license_name");

    /// <summary>
    /// The product_name attribute.
    /// </summary>
    public TerraformValue<string> ProductName
        => AsReference("product_name");

    /// <summary>
    /// The product_sku attribute.
    /// </summary>
    public TerraformValue<string> ProductSku
        => AsReference("product_sku");

    /// <summary>
    /// The received_metadata attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReceivedMetadata
        => AsReference("received_metadata");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The validity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Validity
        => AsReference("validity");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

}
