using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_endpoint in AwsAppstreamImageBuilder.
/// Nesting mode: set
/// </summary>
public class AwsAppstreamImageBuilderAccessEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_endpoint";

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    public required TerraformValue<string> EndpointType
    {
        get => new TerraformReference<string>(this, "endpoint_type");
        set => SetArgument("endpoint_type", value);
    }

    /// <summary>
    /// The vpce_id attribute.
    /// </summary>
    public TerraformValue<string> VpceId
    {
        get => new TerraformReference<string>(this, "vpce_id");
        set => SetArgument("vpce_id", value);
    }

}


/// <summary>
/// Block type for domain_join_info in AwsAppstreamImageBuilder.
/// Nesting mode: list
/// </summary>
public class AwsAppstreamImageBuilderDomainJoinInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "domain_join_info";

    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    public TerraformValue<string>? DirectoryName
    {
        get => new TerraformReference<string>(this, "directory_name");
        set => SetArgument("directory_name", value);
    }

    /// <summary>
    /// The organizational_unit_distinguished_name attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationalUnitDistinguishedName
    {
        get => new TerraformReference<string>(this, "organizational_unit_distinguished_name");
        set => SetArgument("organizational_unit_distinguished_name", value);
    }

}


/// <summary>
/// Block type for vpc_config in AwsAppstreamImageBuilder.
/// Nesting mode: list
/// </summary>
public class AwsAppstreamImageBuilderVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_config";

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
    }

}


/// <summary>
/// Represents a aws_appstream_image_builder Terraform resource.
/// Manages a aws_appstream_image_builder resource.
/// </summary>
public partial class AwsAppstreamImageBuilder(string name) : TerraformResource("aws_appstream_image_builder", name)
{
    /// <summary>
    /// The appstream_agent_version attribute.
    /// </summary>
    public TerraformValue<string> AppstreamAgentVersion
    {
        get => new TerraformReference<string>(this, "appstream_agent_version");
        set => SetArgument("appstream_agent_version", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The enable_default_internet_access attribute.
    /// </summary>
    public TerraformValue<bool> EnableDefaultInternetAccess
    {
        get => new TerraformReference<bool>(this, "enable_default_internet_access");
        set => SetArgument("enable_default_internet_access", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string> IamRoleArn
    {
        get => new TerraformReference<string>(this, "iam_role_arn");
        set => SetArgument("iam_role_arn", value);
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
    /// The image_arn attribute.
    /// </summary>
    public TerraformValue<string> ImageArn
    {
        get => new TerraformReference<string>(this, "image_arn");
        set => SetArgument("image_arn", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    public TerraformValue<string> ImageName
    {
        get => new TerraformReference<string>(this, "image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformValue<string> InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
    {
        get => new TerraformReference<string>(this, "created_time");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// AccessEndpoint block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 AccessEndpoint block(s) allowed")]
    public TerraformSet<AwsAppstreamImageBuilderAccessEndpointBlock>? AccessEndpoint
    {
        get => GetArgument<TerraformSet<AwsAppstreamImageBuilderAccessEndpointBlock>>("access_endpoint");
        set => SetArgument("access_endpoint", value);
    }

    /// <summary>
    /// DomainJoinInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainJoinInfo block(s) allowed")]
    public TerraformList<AwsAppstreamImageBuilderDomainJoinInfoBlock>? DomainJoinInfo
    {
        get => GetArgument<TerraformList<AwsAppstreamImageBuilderDomainJoinInfoBlock>>("domain_join_info");
        set => SetArgument("domain_join_info", value);
    }

    /// <summary>
    /// VpcConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public TerraformList<AwsAppstreamImageBuilderVpcConfigBlock>? VpcConfig
    {
        get => GetArgument<TerraformList<AwsAppstreamImageBuilderVpcConfigBlock>>("vpc_config");
        set => SetArgument("vpc_config", value);
    }

}
