using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_directory_service_directory Terraform data source.
/// Retrieves information about a aws_directory_service_directory.
/// </summary>
public partial class AwsDirectoryServiceDirectoryDataSource(string name) : TerraformDataSource("aws_directory_service_directory", name)
{
    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    public required TerraformValue<string> DirectoryId
    {
        get => GetRequiredArgument<TerraformValue<string>>("directory_id");
        set => SetArgument("directory_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The access_url attribute.
    /// </summary>
    public TerraformValue<string> AccessUrl
        => AsReference("access_url");

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformValue<string> Alias
        => AsReference("alias");

    /// <summary>
    /// The connect_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConnectSettings
        => AsReference("connect_settings");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    public TerraformSet<string> DnsIpAddresses
        => AsReference("dns_ip_addresses");

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public TerraformValue<string> Edition
        => AsReference("edition");

    /// <summary>
    /// The enable_sso attribute.
    /// </summary>
    public TerraformValue<bool> EnableSso
        => AsReference("enable_sso");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The radius_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RadiusSettings
        => AsReference("radius_settings");

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public TerraformValue<string> SecurityGroupId
        => AsReference("security_group_id");

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    public TerraformValue<string> ShortName
        => AsReference("short_name");

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformValue<string> Size
        => AsReference("size");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// The vpc_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VpcSettings
        => AsReference("vpc_settings");

}
