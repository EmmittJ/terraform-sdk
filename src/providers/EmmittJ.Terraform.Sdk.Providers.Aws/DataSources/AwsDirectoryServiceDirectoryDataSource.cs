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
        get => new TerraformReference<string>(this, "directory_id");
        set => SetArgument("directory_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The access_url attribute.
    /// </summary>
    public TerraformValue<string> AccessUrl
    {
        get => new TerraformReference<string>(this, "access_url");
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformValue<string> Alias
    {
        get => new TerraformReference<string>(this, "alias");
    }

    /// <summary>
    /// The connect_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConnectSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "connect_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    public TerraformSet<string> DnsIpAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "dns_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public TerraformValue<string> Edition
    {
        get => new TerraformReference<string>(this, "edition");
    }

    /// <summary>
    /// The enable_sso attribute.
    /// </summary>
    public TerraformValue<bool> EnableSso
    {
        get => new TerraformReference<bool>(this, "enable_sso");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The radius_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RadiusSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "radius_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    public TerraformValue<string> SecurityGroupId
    {
        get => new TerraformReference<string>(this, "security_group_id");
    }

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    public TerraformValue<string> ShortName
    {
        get => new TerraformReference<string>(this, "short_name");
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformValue<string> Size
    {
        get => new TerraformReference<string>(this, "size");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// The vpc_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VpcSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "vpc_settings").ResolveNodes(ctx));
    }

}
