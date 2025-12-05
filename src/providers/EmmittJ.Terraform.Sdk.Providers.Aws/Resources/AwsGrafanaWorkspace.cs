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
        get => GetRequiredArgument<TerraformSet<string>>("prefix_list_ids");
        set => SetArgument("prefix_list_ids", value);
    }

    /// <summary>
    /// The vpce_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpceIds is required")]
    public required TerraformSet<string> VpceIds
    {
        get => GetRequiredArgument<TerraformSet<string>>("vpce_ids");
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
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
        get => GetRequiredArgument<TerraformSet<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
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
        get => GetRequiredArgument<TerraformValue<string>>("account_access_type");
        set => SetArgument("account_access_type", value);
    }

    /// <summary>
    /// The authentication_providers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationProviders is required")]
    public TerraformList<string>? AuthenticationProviders
    {
        get => GetArgument<TerraformList<string>>("authentication_providers");
        set => SetArgument("authentication_providers", value);
    }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformValue<string> Configuration
    {
        get => GetArgument<TerraformValue<string>>("configuration") ?? CreateReference("configuration");
        set => SetArgument("configuration", value);
    }

    /// <summary>
    /// The data_sources attribute.
    /// </summary>
    public TerraformList<string>? DataSources
    {
        get => GetArgument<TerraformList<string>>("data_sources");
        set => SetArgument("data_sources", value);
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
    /// The grafana_version attribute.
    /// </summary>
    public TerraformValue<string> GrafanaVersion
    {
        get => GetArgument<TerraformValue<string>>("grafana_version") ?? CreateReference("grafana_version");
        set => SetArgument("grafana_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The notification_destinations attribute.
    /// </summary>
    public TerraformList<string>? NotificationDestinations
    {
        get => GetArgument<TerraformList<string>>("notification_destinations");
        set => SetArgument("notification_destinations", value);
    }

    /// <summary>
    /// The organization_role_name attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationRoleName
    {
        get => GetArgument<TerraformValue<string>>("organization_role_name");
        set => SetArgument("organization_role_name", value);
    }

    /// <summary>
    /// The organizational_units attribute.
    /// </summary>
    public TerraformList<string>? OrganizationalUnits
    {
        get => GetArgument<TerraformList<string>>("organizational_units");
        set => SetArgument("organizational_units", value);
    }

    /// <summary>
    /// The permission_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionType is required")]
    public required TerraformValue<string> PermissionType
    {
        get => GetRequiredArgument<TerraformValue<string>>("permission_type");
        set => SetArgument("permission_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    public TerraformValue<string>? StackSetName
    {
        get => GetArgument<TerraformValue<string>>("stack_set_name");
        set => SetArgument("stack_set_name", value);
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => CreateReference("endpoint");

    /// <summary>
    /// The saml_configuration_status attribute.
    /// </summary>
    public TerraformValue<string> SamlConfigurationStatus
        => CreateReference("saml_configuration_status");

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
