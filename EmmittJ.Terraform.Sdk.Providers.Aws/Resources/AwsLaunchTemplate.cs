using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_launch_template resource.
/// </summary>
public class AwsLaunchTemplate : TerraformResource
{
    public AwsLaunchTemplate(string name) : base("aws_launch_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("latest_version");
    }

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    public double? DefaultVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("default_version")?.Value;
        set => this.WithProperty("default_version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    public bool? DisableApiStop
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_api_stop")?.Value;
        set => this.WithProperty("disable_api_stop", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    public bool? DisableApiTermination
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_api_termination")?.Value;
        set => this.WithProperty("disable_api_termination", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public string? EbsOptimized
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ebs_optimized")?.Value;
        set => this.WithProperty("ebs_optimized", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public string? ImageId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_id")?.Value;
        set => this.WithProperty("image_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    public string? InstanceInitiatedShutdownBehavior
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_initiated_shutdown_behavior")?.Value;
        set => this.WithProperty("instance_initiated_shutdown_behavior", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public string? InstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_type")?.Value;
        set => this.WithProperty("instance_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    public string? KernelId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kernel_id")?.Value;
        set => this.WithProperty("kernel_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public string? KeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_name")?.Value;
        set => this.WithProperty("key_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public string? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix")?.Value;
        set => this.WithProperty("name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ram_disk_id attribute.
    /// </summary>
    public string? RamDiskId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ram_disk_id")?.Value;
        set => this.WithProperty("ram_disk_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_group_names attribute.
    /// </summary>
    public HashSet<string>? SecurityGroupNames
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_group_names")?.Value;
        set => this.WithProperty("security_group_names", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The update_default_version attribute.
    /// </summary>
    public bool? UpdateDefaultVersion
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("update_default_version")?.Value;
        set => this.WithProperty("update_default_version", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public string? UserData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_data")?.Value;
        set => this.WithProperty("user_data", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<string>? VpcSecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("vpc_security_group_ids")?.Value;
        set => this.WithProperty("vpc_security_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    public TerraformExpression LatestVersion => this["latest_version"];

}
