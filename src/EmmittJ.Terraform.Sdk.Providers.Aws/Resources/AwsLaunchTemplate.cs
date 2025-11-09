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
    public TerraformProperty<double>? DefaultVersion
    {
        get => GetProperty<TerraformProperty<double>>("default_version");
        set => this.WithProperty("default_version", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableApiStop
    {
        get => GetProperty<TerraformProperty<bool>>("disable_api_stop");
        set => this.WithProperty("disable_api_stop", value);
    }

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableApiTermination
    {
        get => GetProperty<TerraformProperty<bool>>("disable_api_termination");
        set => this.WithProperty("disable_api_termination", value);
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformProperty<string>? EbsOptimized
    {
        get => GetProperty<TerraformProperty<string>>("ebs_optimized");
        set => this.WithProperty("ebs_optimized", value);
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
    /// The image_id attribute.
    /// </summary>
    public TerraformProperty<string>? ImageId
    {
        get => GetProperty<TerraformProperty<string>>("image_id");
        set => this.WithProperty("image_id", value);
    }

    /// <summary>
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceInitiatedShutdownBehavior
    {
        get => GetProperty<TerraformProperty<string>>("instance_initiated_shutdown_behavior");
        set => this.WithProperty("instance_initiated_shutdown_behavior", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    public TerraformProperty<string>? KernelId
    {
        get => GetProperty<TerraformProperty<string>>("kernel_id");
        set => this.WithProperty("kernel_id", value);
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformProperty<string>? KeyName
    {
        get => GetProperty<TerraformProperty<string>>("key_name");
        set => this.WithProperty("key_name", value);
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
    /// The ram_disk_id attribute.
    /// </summary>
    public TerraformProperty<string>? RamDiskId
    {
        get => GetProperty<TerraformProperty<string>>("ram_disk_id");
        set => this.WithProperty("ram_disk_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The security_group_names attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SecurityGroupNames
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("security_group_names");
        set => this.WithProperty("security_group_names", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The update_default_version attribute.
    /// </summary>
    public TerraformProperty<bool>? UpdateDefaultVersion
    {
        get => GetProperty<TerraformProperty<bool>>("update_default_version");
        set => this.WithProperty("update_default_version", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformProperty<string>? UserData
    {
        get => GetProperty<TerraformProperty<string>>("user_data");
        set => this.WithProperty("user_data", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? VpcSecurityGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("vpc_security_group_ids");
        set => this.WithProperty("vpc_security_group_ids", value);
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
