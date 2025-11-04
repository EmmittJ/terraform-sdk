using EmmittJ.Terraform.Sdk.Resources;
using EmmittJ.Terraform.Sdk.Context;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ami.
/// </summary>
public class AwsAmiDataSource : TerraformDataSource
{
    public AwsAmiDataSource(string name) : base("aws_ami", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        DeclareOutput("architecture");
        DeclareOutput("arn");
        DeclareOutput("block_device_mappings");
        DeclareOutput("boot_mode");
        DeclareOutput("creation_date");
        DeclareOutput("deprecation_time");
        DeclareOutput("description");
        DeclareOutput("ena_support");
        DeclareOutput("hypervisor");
        DeclareOutput("image_id");
        DeclareOutput("image_location");
        DeclareOutput("image_owner_alias");
        DeclareOutput("image_type");
        DeclareOutput("imds_support");
        DeclareOutput("kernel_id");
        DeclareOutput("last_launched_time");
        DeclareOutput("name");
        DeclareOutput("owner_id");
        DeclareOutput("platform");
        DeclareOutput("platform_details");
        DeclareOutput("product_codes");
        DeclareOutput("public");
        DeclareOutput("ramdisk_id");
        DeclareOutput("root_device_name");
        DeclareOutput("root_device_type");
        DeclareOutput("root_snapshot_id");
        DeclareOutput("sriov_net_support");
        DeclareOutput("state");
        DeclareOutput("state_reason");
        DeclareOutput("tpm_support");
        DeclareOutput("usage_operation");
        DeclareOutput("virtualization_type");
    }

    /// <summary>
    /// The executable_users attribute.
    /// </summary>
    public List&lt;string&gt;? ExecutableUsers
    {
        get => GetProperty<TerraformLiteralProperty&lt;List&lt;string&gt;&gt;>("executable_users")?.Value;
        set => WithPropertyInternal("executable_users", value == null ? null : new TerraformLiteralProperty&lt;List&lt;string&gt;&gt;(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("id")?.Value;
        set => WithPropertyInternal("id", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The include_deprecated attribute.
    /// </summary>
    public bool? IncludeDeprecated
    {
        get => GetProperty<TerraformLiteralProperty&lt;bool&gt;>("include_deprecated")?.Value;
        set => WithPropertyInternal("include_deprecated", value == null ? null : new TerraformLiteralProperty&lt;bool&gt;(value.Value));
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public bool? MostRecent
    {
        get => GetProperty<TerraformLiteralProperty&lt;bool&gt;>("most_recent")?.Value;
        set => WithPropertyInternal("most_recent", value == null ? null : new TerraformLiteralProperty&lt;bool&gt;(value.Value));
    }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    public string? NameRegex
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("name_regex")?.Value;
        set => WithPropertyInternal("name_regex", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The owners attribute.
    /// </summary>
    public List&lt;string&gt;? Owners
    {
        get => GetProperty<TerraformLiteralProperty&lt;List&lt;string&gt;&gt;>("owners")?.Value;
        set => WithPropertyInternal("owners", value == null ? null : new TerraformLiteralProperty&lt;List&lt;string&gt;&gt;(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary&lt;string, string&gt;? Tags
    {
        get => GetProperty<TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;>("tags")?.Value;
        set => WithPropertyInternal("tags", value == null ? null : new TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;(value));
    }

    /// <summary>
    /// The uefi_data attribute.
    /// </summary>
    public string? UefiData
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("uefi_data")?.Value;
        set => WithPropertyInternal("uefi_data", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    public TerraformExpression Architecture => this["architecture"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The block_device_mappings attribute.
    /// </summary>
    public TerraformExpression BlockDeviceMappings => this["block_device_mappings"];

    /// <summary>
    /// The boot_mode attribute.
    /// </summary>
    public TerraformExpression BootMode => this["boot_mode"];

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformExpression CreationDate => this["creation_date"];

    /// <summary>
    /// The deprecation_time attribute.
    /// </summary>
    public TerraformExpression DeprecationTime => this["deprecation_time"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The ena_support attribute.
    /// </summary>
    public TerraformExpression EnaSupport => this["ena_support"];

    /// <summary>
    /// The hypervisor attribute.
    /// </summary>
    public TerraformExpression Hypervisor => this["hypervisor"];

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformExpression ImageId => this["image_id"];

    /// <summary>
    /// The image_location attribute.
    /// </summary>
    public TerraformExpression ImageLocation => this["image_location"];

    /// <summary>
    /// The image_owner_alias attribute.
    /// </summary>
    public TerraformExpression ImageOwnerAlias => this["image_owner_alias"];

    /// <summary>
    /// The image_type attribute.
    /// </summary>
    public TerraformExpression ImageType => this["image_type"];

    /// <summary>
    /// The imds_support attribute.
    /// </summary>
    public TerraformExpression ImdsSupport => this["imds_support"];

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    public TerraformExpression KernelId => this["kernel_id"];

    /// <summary>
    /// The last_launched_time attribute.
    /// </summary>
    public TerraformExpression LastLaunchedTime => this["last_launched_time"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformExpression Platform => this["platform"];

    /// <summary>
    /// The platform_details attribute.
    /// </summary>
    public TerraformExpression PlatformDetails => this["platform_details"];

    /// <summary>
    /// The product_codes attribute.
    /// </summary>
    public TerraformExpression ProductCodes => this["product_codes"];

    /// <summary>
    /// The public attribute.
    /// </summary>
    public TerraformExpression Public => this["public"];

    /// <summary>
    /// The ramdisk_id attribute.
    /// </summary>
    public TerraformExpression RamdiskId => this["ramdisk_id"];

    /// <summary>
    /// The root_device_name attribute.
    /// </summary>
    public TerraformExpression RootDeviceName => this["root_device_name"];

    /// <summary>
    /// The root_device_type attribute.
    /// </summary>
    public TerraformExpression RootDeviceType => this["root_device_type"];

    /// <summary>
    /// The root_snapshot_id attribute.
    /// </summary>
    public TerraformExpression RootSnapshotId => this["root_snapshot_id"];

    /// <summary>
    /// The sriov_net_support attribute.
    /// </summary>
    public TerraformExpression SriovNetSupport => this["sriov_net_support"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The state_reason attribute.
    /// </summary>
    public TerraformExpression StateReason => this["state_reason"];

    /// <summary>
    /// The tpm_support attribute.
    /// </summary>
    public TerraformExpression TpmSupport => this["tpm_support"];

    /// <summary>
    /// The usage_operation attribute.
    /// </summary>
    public TerraformExpression UsageOperation => this["usage_operation"];

    /// <summary>
    /// The virtualization_type attribute.
    /// </summary>
    public TerraformExpression VirtualizationType => this["virtualization_type"];

}
