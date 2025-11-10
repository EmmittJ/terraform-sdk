using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for custom_dns_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxEnvironmentCustomDnsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The custom_dns_server_ip attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomDnsServerIp is required")]
    public required TerraformProperty<string> CustomDnsServerIp
    {
        get => GetRequiredProperty<TerraformProperty<string>>("custom_dns_server_ip");
        set => WithProperty("custom_dns_server_ip", value);
    }

    /// <summary>
    /// The custom_dns_server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomDnsServerName is required")]
    public required TerraformProperty<string> CustomDnsServerName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("custom_dns_server_name");
        set => WithProperty("custom_dns_server_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFinspaceKxEnvironmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for transit_gateway_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The routable_cidr_space attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutableCidrSpace is required")]
    public required TerraformProperty<string> RoutableCidrSpace
    {
        get => GetRequiredProperty<TerraformProperty<string>>("routable_cidr_space");
        set => WithProperty("routable_cidr_space", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayId is required")]
    public required TerraformProperty<string> TransitGatewayId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("transit_gateway_id");
        set => WithProperty("transit_gateway_id", value);
    }

}

/// <summary>
/// Manages a aws_finspace_kx_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFinspaceKxEnvironment : TerraformResource
{
    public AwsFinspaceKxEnvironment(string name) : base("aws_finspace_kx_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("availability_zones");
        this.DeclareOutput("created_timestamp");
        this.DeclareOutput("id");
        this.DeclareOutput("infrastructure_account_id");
        this.DeclareOutput("last_modified_timestamp");
        this.DeclareOutput("status");
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
    /// The kms_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyId is required")]
    public required TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for custom_dns_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsFinspaceKxEnvironmentCustomDnsConfigurationBlock>? CustomDnsConfiguration
    {
        get => GetProperty<List<AwsFinspaceKxEnvironmentCustomDnsConfigurationBlock>>("custom_dns_configuration");
        set => this.WithProperty("custom_dns_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFinspaceKxEnvironmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsFinspaceKxEnvironmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for transit_gateway_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TransitGatewayConfiguration block(s) allowed")]
    public List<AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlock>? TransitGatewayConfiguration
    {
        get => GetProperty<List<AwsFinspaceKxEnvironmentTransitGatewayConfigurationBlock>>("transit_gateway_configuration");
        set => this.WithProperty("transit_gateway_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformExpression AvailabilityZones => this["availability_zones"];

    /// <summary>
    /// The created_timestamp attribute.
    /// </summary>
    public TerraformExpression CreatedTimestamp => this["created_timestamp"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The infrastructure_account_id attribute.
    /// </summary>
    public TerraformExpression InfrastructureAccountId => this["infrastructure_account_id"];

    /// <summary>
    /// The last_modified_timestamp attribute.
    /// </summary>
    public TerraformExpression LastModifiedTimestamp => this["last_modified_timestamp"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
