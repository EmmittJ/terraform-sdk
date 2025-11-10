using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for connect_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDirectoryServiceDirectoryConnectSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AvailabilityZones
    {
        set => SetProperty("availability_zones", value);
    }

    /// <summary>
    /// The connect_ips attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ConnectIps
    {
        set => SetProperty("connect_ips", value);
    }

    /// <summary>
    /// The customer_dns_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerDnsIps is required")]
    public HashSet<TerraformProperty<string>>? CustomerDnsIps
    {
        set => SetProperty("customer_dns_ips", value);
    }

    /// <summary>
    /// The customer_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerUsername is required")]
    public required TerraformProperty<string> CustomerUsername
    {
        set => SetProperty("customer_username", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        set => SetProperty("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        set => SetProperty("vpc_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDirectoryServiceDirectoryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for vpc_settings in .
/// Nesting mode: list
/// </summary>
public class AwsDirectoryServiceDirectoryVpcSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AvailabilityZones
    {
        set => SetProperty("availability_zones", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        set => SetProperty("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        set => SetProperty("vpc_id", value);
    }

}

/// <summary>
/// Manages a aws_directory_service_directory resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDirectoryServiceDirectory : TerraformResource
{
    public AwsDirectoryServiceDirectory(string name) : base("aws_directory_service_directory", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("access_url");
        SetOutput("dns_ip_addresses");
        SetOutput("security_group_id");
        SetOutput("alias");
        SetOutput("description");
        SetOutput("desired_number_of_domain_controllers");
        SetOutput("edition");
        SetOutput("enable_sso");
        SetOutput("id");
        SetOutput("name");
        SetOutput("password");
        SetOutput("region");
        SetOutput("short_name");
        SetOutput("size");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("type");
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformProperty<string> Alias
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alias");
        set => SetProperty("alias", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The desired_number_of_domain_controllers attribute.
    /// </summary>
    public TerraformProperty<double> DesiredNumberOfDomainControllers
    {
        get => GetRequiredOutput<TerraformProperty<double>>("desired_number_of_domain_controllers");
        set => SetProperty("desired_number_of_domain_controllers", value);
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public TerraformProperty<string> Edition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("edition");
        set => SetProperty("edition", value);
    }

    /// <summary>
    /// The enable_sso attribute.
    /// </summary>
    public TerraformProperty<bool> EnableSso
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_sso");
        set => SetProperty("enable_sso", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    public TerraformProperty<string> ShortName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("short_name");
        set => SetProperty("short_name", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformProperty<string> Size
    {
        get => GetRequiredOutput<TerraformProperty<string>>("size");
        set => SetProperty("size", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for connect_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectSettings block(s) allowed")]
    public List<AwsDirectoryServiceDirectoryConnectSettingsBlock>? ConnectSettings
    {
        set => SetProperty("connect_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDirectoryServiceDirectoryTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcSettings block(s) allowed")]
    public List<AwsDirectoryServiceDirectoryVpcSettingsBlock>? VpcSettings
    {
        set => SetProperty("vpc_settings", value);
    }

    /// <summary>
    /// The access_url attribute.
    /// </summary>
    public TerraformExpression AccessUrl => this["access_url"];

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    public TerraformExpression DnsIpAddresses => this["dns_ip_addresses"];

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public TerraformExpression SecurityGroupId => this["security_group_id"];

}
