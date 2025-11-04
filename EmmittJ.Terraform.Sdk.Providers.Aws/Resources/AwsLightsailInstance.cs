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
    public string? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone")?.Value;
        set => this.WithProperty("availability_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The blueprint_id attribute.
    /// </summary>
    public string? BlueprintId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("blueprint_id")?.Value;
        set => this.WithProperty("blueprint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    public string? BundleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bundle_id")?.Value;
        set => this.WithProperty("bundle_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ip_address_type attribute.
    /// </summary>
    public string? IpAddressType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_address_type")?.Value;
        set => this.WithProperty("ip_address_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key_pair_name attribute.
    /// </summary>
    public string? KeyPairName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_pair_name")?.Value;
        set => this.WithProperty("key_pair_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The user_data attribute.
    /// </summary>
    public string? UserData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_data")?.Value;
        set => this.WithProperty("user_data", value == null ? null : new TerraformLiteralProperty<string>(value));
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
