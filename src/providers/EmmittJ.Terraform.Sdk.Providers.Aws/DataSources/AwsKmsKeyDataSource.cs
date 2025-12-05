using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_kms_key Terraform data source.
/// Retrieves information about a aws_kms_key.
/// </summary>
public partial class AwsKmsKeyDataSource(string name) : TerraformDataSource("aws_kms_key", name)
{
    /// <summary>
    /// The grant_tokens attribute.
    /// </summary>
    public TerraformList<string>? GrantTokens
    {
        get => GetArgument<TerraformList<string>>("grant_tokens");
        set => SetArgument("grant_tokens", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformValue<string> KeyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string> AwsAccountId
        => CreateReference("aws_account_id");

    /// <summary>
    /// The cloud_hsm_cluster_id attribute.
    /// </summary>
    public TerraformValue<string> CloudHsmClusterId
        => CreateReference("cloud_hsm_cluster_id");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformValue<string> CreationDate
        => CreateReference("creation_date");

    /// <summary>
    /// The custom_key_store_id attribute.
    /// </summary>
    public TerraformValue<string> CustomKeyStoreId
        => CreateReference("custom_key_store_id");

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    public TerraformValue<string> CustomerMasterKeySpec
        => CreateReference("customer_master_key_spec");

    /// <summary>
    /// The deletion_date attribute.
    /// </summary>
    public TerraformValue<string> DeletionDate
        => CreateReference("deletion_date");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
        => CreateReference("enabled");

    /// <summary>
    /// The expiration_model attribute.
    /// </summary>
    public TerraformValue<string> ExpirationModel
        => CreateReference("expiration_model");

    /// <summary>
    /// The key_manager attribute.
    /// </summary>
    public TerraformValue<string> KeyManager
        => CreateReference("key_manager");

    /// <summary>
    /// The key_spec attribute.
    /// </summary>
    public TerraformValue<string> KeySpec
        => CreateReference("key_spec");

    /// <summary>
    /// The key_state attribute.
    /// </summary>
    public TerraformValue<string> KeyState
        => CreateReference("key_state");

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    public TerraformValue<string> KeyUsage
        => CreateReference("key_usage");

    /// <summary>
    /// The multi_region attribute.
    /// </summary>
    public TerraformValue<bool> MultiRegion
        => CreateReference("multi_region");

    /// <summary>
    /// The multi_region_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MultiRegionConfiguration
        => CreateReference("multi_region_configuration");

    /// <summary>
    /// The origin attribute.
    /// </summary>
    public TerraformValue<string> Origin
        => CreateReference("origin");

    /// <summary>
    /// The pending_deletion_window_in_days attribute.
    /// </summary>
    public TerraformValue<double> PendingDeletionWindowInDays
        => CreateReference("pending_deletion_window_in_days");

    /// <summary>
    /// The valid_to attribute.
    /// </summary>
    public TerraformValue<string> ValidTo
        => CreateReference("valid_to");

    /// <summary>
    /// The xks_key_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> XksKeyConfiguration
        => CreateReference("xks_key_configuration");

}
