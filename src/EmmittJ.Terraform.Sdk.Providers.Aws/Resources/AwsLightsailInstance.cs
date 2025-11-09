using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lightsail_instance resource.
/// </summary>
public class AwsLightsailInstance : TerraformResource
{
    public AwsLightsailInstance(string name) : base("aws_lightsail_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("cpu_count");
        this.DeclareOutput("created_at");
        this.DeclareOutput("ipv6_addresses");
        this.DeclareOutput("is_static_ip");
        this.DeclareOutput("private_ip_address");
        this.DeclareOutput("public_ip_address");
        this.DeclareOutput("ram_size");
        this.DeclareOutput("username");
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The blueprint_id attribute.
    /// </summary>
    public TerraformProperty<string>? BlueprintId
    {
        get => GetProperty<TerraformProperty<string>>("blueprint_id");
        set => this.WithProperty("blueprint_id", value);
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    public TerraformProperty<string>? BundleId
    {
        get => GetProperty<TerraformProperty<string>>("bundle_id");
        set => this.WithProperty("bundle_id", value);
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
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddressType
    {
        get => GetProperty<TerraformProperty<string>>("ip_address_type");
        set => this.WithProperty("ip_address_type", value);
    }

    /// <summary>
    /// The key_pair_name attribute.
    /// </summary>
    public TerraformProperty<string>? KeyPairName
    {
        get => GetProperty<TerraformProperty<string>>("key_pair_name");
        set => this.WithProperty("key_pair_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
    /// The user_data attribute.
    /// </summary>
    public TerraformProperty<string>? UserData
    {
        get => GetProperty<TerraformProperty<string>>("user_data");
        set => this.WithProperty("user_data", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cpu_count attribute.
    /// </summary>
    public TerraformExpression CpuCount => this["cpu_count"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public TerraformExpression Ipv6Addresses => this["ipv6_addresses"];

    /// <summary>
    /// The is_static_ip attribute.
    /// </summary>
    public TerraformExpression IsStaticIp => this["is_static_ip"];

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformExpression PrivateIpAddress => this["private_ip_address"];

    /// <summary>
    /// The public_ip_address attribute.
    /// </summary>
    public TerraformExpression PublicIpAddress => this["public_ip_address"];

    /// <summary>
    /// The ram_size attribute.
    /// </summary>
    public TerraformExpression RamSize => this["ram_size"];

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformExpression Username => this["username"];

}
