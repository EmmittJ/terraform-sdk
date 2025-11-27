using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_emr_studio Terraform resource.
/// Manages a aws_emr_studio resource.
/// </summary>
public partial class AwsEmrStudio(string name) : TerraformResource("aws_emr_studio", name)
{
    /// <summary>
    /// The auth_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthMode is required")]
    public required TerraformValue<string> AuthMode
    {
        get => new TerraformReference<string>(this, "auth_mode");
        set => SetArgument("auth_mode", value);
    }

    /// <summary>
    /// The default_s3_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultS3Location is required")]
    public required TerraformValue<string> DefaultS3Location
    {
        get => new TerraformReference<string>(this, "default_s3_location");
        set => SetArgument("default_s3_location", value);
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
    /// The encryption_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionKeyArn
    {
        get => new TerraformReference<string>(this, "encryption_key_arn");
        set => SetArgument("encryption_key_arn", value);
    }

    /// <summary>
    /// The engine_security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineSecurityGroupId is required")]
    public required TerraformValue<string> EngineSecurityGroupId
    {
        get => new TerraformReference<string>(this, "engine_security_group_id");
        set => SetArgument("engine_security_group_id", value);
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
    /// The idp_auth_url attribute.
    /// </summary>
    public TerraformValue<string>? IdpAuthUrl
    {
        get => new TerraformReference<string>(this, "idp_auth_url");
        set => SetArgument("idp_auth_url", value);
    }

    /// <summary>
    /// The idp_relay_state_parameter_name attribute.
    /// </summary>
    public TerraformValue<string>? IdpRelayStateParameterName
    {
        get => new TerraformReference<string>(this, "idp_relay_state_parameter_name");
        set => SetArgument("idp_relay_state_parameter_name", value);
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
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    public required TerraformValue<string> ServiceRole
    {
        get => new TerraformReference<string>(this, "service_role");
        set => SetArgument("service_role", value);
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
    /// The user_role attribute.
    /// </summary>
    public TerraformValue<string>? UserRole
    {
        get => new TerraformReference<string>(this, "user_role");
        set => SetArgument("user_role", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The workspace_security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceSecurityGroupId is required")]
    public required TerraformValue<string> WorkspaceSecurityGroupId
    {
        get => new TerraformReference<string>(this, "workspace_security_group_id");
        set => SetArgument("workspace_security_group_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
    }

}
