using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_emr_studio resource.
/// </summary>
public class AwsEmrStudio : TerraformResource
{
    public AwsEmrStudio(string name) : base("aws_emr_studio", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("url");
    }

    /// <summary>
    /// The auth_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthMode is required")]
    public required TerraformProperty<string> AuthMode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("auth_mode");
        set => this.WithProperty("auth_mode", value);
    }

    /// <summary>
    /// The default_s3_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultS3Location is required")]
    public required TerraformProperty<string> DefaultS3Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("default_s3_location");
        set => this.WithProperty("default_s3_location", value);
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
    /// The encryption_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("encryption_key_arn");
        set => this.WithProperty("encryption_key_arn", value);
    }

    /// <summary>
    /// The engine_security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineSecurityGroupId is required")]
    public required TerraformProperty<string> EngineSecurityGroupId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("engine_security_group_id");
        set => this.WithProperty("engine_security_group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The idp_auth_url attribute.
    /// </summary>
    public TerraformProperty<string>? IdpAuthUrl
    {
        get => GetProperty<TerraformProperty<string>>("idp_auth_url");
        set => this.WithProperty("idp_auth_url", value);
    }

    /// <summary>
    /// The idp_relay_state_parameter_name attribute.
    /// </summary>
    public TerraformProperty<string>? IdpRelayStateParameterName
    {
        get => GetProperty<TerraformProperty<string>>("idp_relay_state_parameter_name");
        set => this.WithProperty("idp_relay_state_parameter_name", value);
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
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    public required TerraformProperty<string> ServiceRole
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_role");
        set => this.WithProperty("service_role", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
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
    /// The user_role attribute.
    /// </summary>
    public TerraformProperty<string>? UserRole
    {
        get => GetProperty<TerraformProperty<string>>("user_role");
        set => this.WithProperty("user_role", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

    /// <summary>
    /// The workspace_security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceSecurityGroupId is required")]
    public required TerraformProperty<string> WorkspaceSecurityGroupId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("workspace_security_group_id");
        set => this.WithProperty("workspace_security_group_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
