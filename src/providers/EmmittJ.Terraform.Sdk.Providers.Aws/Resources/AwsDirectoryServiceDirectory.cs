using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for connect_settings in AwsDirectoryServiceDirectory.
/// Nesting mode: list
/// </summary>
public class AwsDirectoryServiceDirectoryConnectSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connect_settings";

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string> AvailabilityZones
        => AsReference("availability_zones");

    /// <summary>
    /// The connect_ips attribute.
    /// </summary>
    public TerraformSet<string> ConnectIps
        => AsReference("connect_ips");

    /// <summary>
    /// The customer_dns_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerDnsIps is required")]
    public required TerraformSet<string> CustomerDnsIps
    {
        get => GetRequiredArgument<TerraformSet<string>>("customer_dns_ips");
        set => SetArgument("customer_dns_ips", value);
    }

    /// <summary>
    /// The customer_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerUsername is required")]
    public required TerraformValue<string> CustomerUsername
    {
        get => GetRequiredArgument<TerraformValue<string>>("customer_username");
        set => SetArgument("customer_username", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => GetRequiredArgument<TerraformSet<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformValue<string> VpcId
    {
        get => GetRequiredArgument<TerraformValue<string>>("vpc_id");
        set => SetArgument("vpc_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDirectoryServiceDirectory.
/// Nesting mode: single
/// </summary>
public class AwsDirectoryServiceDirectoryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for vpc_settings in AwsDirectoryServiceDirectory.
/// Nesting mode: list
/// </summary>
public class AwsDirectoryServiceDirectoryVpcSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_settings";

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string> AvailabilityZones
        => AsReference("availability_zones");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => GetRequiredArgument<TerraformSet<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformValue<string> VpcId
    {
        get => GetRequiredArgument<TerraformValue<string>>("vpc_id");
        set => SetArgument("vpc_id", value);
    }

}


/// <summary>
/// Represents a aws_directory_service_directory Terraform resource.
/// Manages a aws_directory_service_directory resource.
/// </summary>
public partial class AwsDirectoryServiceDirectory(string name) : TerraformResource("aws_directory_service_directory", name)
{
    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformValue<string> Alias
    {
        get => GetArgument<TerraformValue<string>>("alias") ?? AsReference("alias");
        set => SetArgument("alias", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The desired_number_of_domain_controllers attribute.
    /// </summary>
    public TerraformValue<double> DesiredNumberOfDomainControllers
    {
        get => GetArgument<TerraformValue<double>>("desired_number_of_domain_controllers") ?? AsReference("desired_number_of_domain_controllers");
        set => SetArgument("desired_number_of_domain_controllers", value);
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public TerraformValue<string> Edition
    {
        get => GetArgument<TerraformValue<string>>("edition") ?? AsReference("edition");
        set => SetArgument("edition", value);
    }

    /// <summary>
    /// The enable_sso attribute.
    /// </summary>
    public TerraformValue<bool>? EnableSso
    {
        get => GetArgument<TerraformValue<bool>>("enable_sso");
        set => SetArgument("enable_sso", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    public TerraformValue<string> ShortName
    {
        get => GetArgument<TerraformValue<string>>("short_name") ?? AsReference("short_name");
        set => SetArgument("short_name", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformValue<string> Size
    {
        get => GetArgument<TerraformValue<string>>("size") ?? AsReference("size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The access_url attribute.
    /// </summary>
    public TerraformValue<string> AccessUrl
        => AsReference("access_url");

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    public TerraformSet<string> DnsIpAddresses
        => AsReference("dns_ip_addresses");

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public TerraformValue<string> SecurityGroupId
        => AsReference("security_group_id");

    /// <summary>
    /// ConnectSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectSettings block(s) allowed")]
    public TerraformList<AwsDirectoryServiceDirectoryConnectSettingsBlock>? ConnectSettings
    {
        get => GetArgument<TerraformList<AwsDirectoryServiceDirectoryConnectSettingsBlock>>("connect_settings");
        set => SetArgument("connect_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDirectoryServiceDirectoryTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDirectoryServiceDirectoryTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VpcSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcSettings block(s) allowed")]
    public TerraformList<AwsDirectoryServiceDirectoryVpcSettingsBlock>? VpcSettings
    {
        get => GetArgument<TerraformList<AwsDirectoryServiceDirectoryVpcSettingsBlock>>("vpc_settings");
        set => SetArgument("vpc_settings", value);
    }

}
