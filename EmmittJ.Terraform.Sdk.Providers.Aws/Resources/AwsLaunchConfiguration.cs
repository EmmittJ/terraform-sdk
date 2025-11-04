using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_launch_configuration resource.
/// </summary>
public class AwsLaunchConfiguration : TerraformResource
{
    public AwsLaunchConfiguration(string name) : base("aws_launch_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public bool? AssociatePublicIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("associate_public_ip_address")?.Value;
        set => this.WithProperty("associate_public_ip_address", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public bool? EbsOptimized
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ebs_optimized")?.Value;
        set => this.WithProperty("ebs_optimized", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_monitoring attribute.
    /// </summary>
    public bool? EnableMonitoring
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_monitoring")?.Value;
        set => this.WithProperty("enable_monitoring", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public string? IamInstanceProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_instance_profile")?.Value;
        set => this.WithProperty("iam_instance_profile", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The instance_type attribute.
    /// </summary>
    public string? InstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_type")?.Value;
        set => this.WithProperty("instance_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The placement_tenancy attribute.
    /// </summary>
    public string? PlacementTenancy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("placement_tenancy")?.Value;
        set => this.WithProperty("placement_tenancy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<string>? SecurityGroups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_groups")?.Value;
        set => this.WithProperty("security_groups", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    public string? SpotPrice
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spot_price")?.Value;
        set => this.WithProperty("spot_price", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The user_data_base64 attribute.
    /// </summary>
    public string? UserDataBase64
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_data_base64")?.Value;
        set => this.WithProperty("user_data_base64", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
