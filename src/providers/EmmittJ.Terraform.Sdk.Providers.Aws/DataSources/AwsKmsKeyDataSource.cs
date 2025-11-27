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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "grant_tokens").ResolveNodes(ctx));
        set => SetArgument("grant_tokens", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformValue<string> KeyId
    {
        get => new TerraformReference<string>(this, "key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string> AwsAccountId
    {
        get => new TerraformReference<string>(this, "aws_account_id");
    }

    /// <summary>
    /// The cloud_hsm_cluster_id attribute.
    /// </summary>
    public TerraformValue<string> CloudHsmClusterId
    {
        get => new TerraformReference<string>(this, "cloud_hsm_cluster_id");
    }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformValue<string> CreationDate
    {
        get => new TerraformReference<string>(this, "creation_date");
    }

    /// <summary>
    /// The custom_key_store_id attribute.
    /// </summary>
    public TerraformValue<string> CustomKeyStoreId
    {
        get => new TerraformReference<string>(this, "custom_key_store_id");
    }

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    public TerraformValue<string> CustomerMasterKeySpec
    {
        get => new TerraformReference<string>(this, "customer_master_key_spec");
    }

    /// <summary>
    /// The deletion_date attribute.
    /// </summary>
    public TerraformValue<string> DeletionDate
    {
        get => new TerraformReference<string>(this, "deletion_date");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
    }

    /// <summary>
    /// The expiration_model attribute.
    /// </summary>
    public TerraformValue<string> ExpirationModel
    {
        get => new TerraformReference<string>(this, "expiration_model");
    }

    /// <summary>
    /// The key_manager attribute.
    /// </summary>
    public TerraformValue<string> KeyManager
    {
        get => new TerraformReference<string>(this, "key_manager");
    }

    /// <summary>
    /// The key_spec attribute.
    /// </summary>
    public TerraformValue<string> KeySpec
    {
        get => new TerraformReference<string>(this, "key_spec");
    }

    /// <summary>
    /// The key_state attribute.
    /// </summary>
    public TerraformValue<string> KeyState
    {
        get => new TerraformReference<string>(this, "key_state");
    }

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    public TerraformValue<string> KeyUsage
    {
        get => new TerraformReference<string>(this, "key_usage");
    }

    /// <summary>
    /// The multi_region attribute.
    /// </summary>
    public TerraformValue<bool> MultiRegion
    {
        get => new TerraformReference<bool>(this, "multi_region");
    }

    /// <summary>
    /// The multi_region_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MultiRegionConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "multi_region_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The origin attribute.
    /// </summary>
    public TerraformValue<string> Origin
    {
        get => new TerraformReference<string>(this, "origin");
    }

    /// <summary>
    /// The pending_deletion_window_in_days attribute.
    /// </summary>
    public TerraformValue<double> PendingDeletionWindowInDays
    {
        get => new TerraformReference<double>(this, "pending_deletion_window_in_days");
    }

    /// <summary>
    /// The valid_to attribute.
    /// </summary>
    public TerraformValue<string> ValidTo
    {
        get => new TerraformReference<string>(this, "valid_to");
    }

    /// <summary>
    /// The xks_key_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> XksKeyConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "xks_key_configuration").ResolveNodes(ctx));
    }

}
