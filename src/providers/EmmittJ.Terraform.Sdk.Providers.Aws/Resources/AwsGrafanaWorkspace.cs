using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for network_access_control in AwsGrafanaWorkspace.
/// Nesting mode: list
/// </summary>
public class AwsGrafanaWorkspaceNetworkAccessControlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_access_control";

    /// <summary>
    /// The prefix_list_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrefixListIds is required")]
    public required TerraformSet<string> PrefixListIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "prefix_list_ids").ResolveNodes(ctx));
        set => SetArgument("prefix_list_ids", value);
    }

    /// <summary>
    /// The vpce_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpceIds is required")]
    public required TerraformSet<string> VpceIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpce_ids").ResolveNodes(ctx));
        set => SetArgument("vpce_ids", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsGrafanaWorkspace.
/// Nesting mode: single
/// </summary>
public class AwsGrafanaWorkspaceTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for vpc_configuration in AwsGrafanaWorkspace.
/// Nesting mode: list
/// </summary>
public class AwsGrafanaWorkspaceVpcConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_configuration";

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public required TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
    }

}


/// <summary>
/// Represents a aws_grafana_workspace Terraform resource.
/// Manages a aws_grafana_workspace resource.
/// </summary>
public partial class AwsGrafanaWorkspace(string name) : TerraformResource("aws_grafana_workspace", name)
{
    /// <summary>
    /// The account_access_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountAccessType is required")]
    public required TerraformValue<string> AccountAccessType
    {
        get => new TerraformReference<string>(this, "account_access_type");
        set => SetArgument("account_access_type", value);
    }

    /// <summary>
    /// The authentication_providers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationProviders is required")]
    public TerraformList<string>? AuthenticationProviders
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "authentication_providers").ResolveNodes(ctx));
        set => SetArgument("authentication_providers", value);
    }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformValue<string> Configuration
    {
        get => new TerraformReference<string>(this, "configuration");
        set => SetArgument("configuration", value);
    }

    /// <summary>
    /// The data_sources attribute.
    /// </summary>
    public TerraformList<string>? DataSources
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "data_sources").ResolveNodes(ctx));
        set => SetArgument("data_sources", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The grafana_version attribute.
    /// </summary>
    public TerraformValue<string> GrafanaVersion
    {
        get => new TerraformReference<string>(this, "grafana_version");
        set => SetArgument("grafana_version", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The notification_destinations attribute.
    /// </summary>
    public TerraformList<string>? NotificationDestinations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "notification_destinations").ResolveNodes(ctx));
        set => SetArgument("notification_destinations", value);
    }

    /// <summary>
    /// The organization_role_name attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationRoleName
    {
        get => new TerraformReference<string>(this, "organization_role_name");
        set => SetArgument("organization_role_name", value);
    }

    /// <summary>
    /// The organizational_units attribute.
    /// </summary>
    public TerraformList<string>? OrganizationalUnits
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "organizational_units").ResolveNodes(ctx));
        set => SetArgument("organizational_units", value);
    }

    /// <summary>
    /// The permission_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionType is required")]
    public required TerraformValue<string> PermissionType
    {
        get => new TerraformReference<string>(this, "permission_type");
        set => SetArgument("permission_type", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    public TerraformValue<string>? StackSetName
    {
        get => new TerraformReference<string>(this, "stack_set_name");
        set => SetArgument("stack_set_name", value);
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
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The saml_configuration_status attribute.
    /// </summary>
    public TerraformValue<string> SamlConfigurationStatus
    {
        get => new TerraformReference<string>(this, "saml_configuration_status");
    }

    /// <summary>
    /// NetworkAccessControl block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAccessControl block(s) allowed")]
    public TerraformList<AwsGrafanaWorkspaceNetworkAccessControlBlock>? NetworkAccessControl
    {
        get => GetArgument<TerraformList<AwsGrafanaWorkspaceNetworkAccessControlBlock>>("network_access_control");
        set => SetArgument("network_access_control", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsGrafanaWorkspaceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsGrafanaWorkspaceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VpcConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfiguration block(s) allowed")]
    public TerraformList<AwsGrafanaWorkspaceVpcConfigurationBlock>? VpcConfiguration
    {
        get => GetArgument<TerraformList<AwsGrafanaWorkspaceVpcConfigurationBlock>>("vpc_configuration");
        set => SetArgument("vpc_configuration", value);
    }

}
