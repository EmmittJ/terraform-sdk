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
        SetOutput("arn");
        SetOutput("url");
        SetOutput("auth_mode");
        SetOutput("default_s3_location");
        SetOutput("description");
        SetOutput("encryption_key_arn");
        SetOutput("engine_security_group_id");
        SetOutput("id");
        SetOutput("idp_auth_url");
        SetOutput("idp_relay_state_parameter_name");
        SetOutput("name");
        SetOutput("region");
        SetOutput("service_role");
        SetOutput("subnet_ids");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("user_role");
        SetOutput("vpc_id");
        SetOutput("workspace_security_group_id");
    }

    /// <summary>
    /// The auth_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthMode is required")]
    public required TerraformProperty<string> AuthMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("auth_mode");
        set => SetProperty("auth_mode", value);
    }

    /// <summary>
    /// The default_s3_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultS3Location is required")]
    public required TerraformProperty<string> DefaultS3Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_s3_location");
        set => SetProperty("default_s3_location", value);
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
    /// The encryption_key_arn attribute.
    /// </summary>
    public TerraformProperty<string> EncryptionKeyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("encryption_key_arn");
        set => SetProperty("encryption_key_arn", value);
    }

    /// <summary>
    /// The engine_security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineSecurityGroupId is required")]
    public required TerraformProperty<string> EngineSecurityGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_security_group_id");
        set => SetProperty("engine_security_group_id", value);
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
    /// The idp_auth_url attribute.
    /// </summary>
    public TerraformProperty<string> IdpAuthUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("idp_auth_url");
        set => SetProperty("idp_auth_url", value);
    }

    /// <summary>
    /// The idp_relay_state_parameter_name attribute.
    /// </summary>
    public TerraformProperty<string> IdpRelayStateParameterName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("idp_relay_state_parameter_name");
        set => SetProperty("idp_relay_state_parameter_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    public required TerraformProperty<string> ServiceRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_role");
        set => SetProperty("service_role", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>> SubnetIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => SetProperty("subnet_ids", value);
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
    /// The user_role attribute.
    /// </summary>
    public TerraformProperty<string> UserRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_role");
        set => SetProperty("user_role", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_id");
        set => SetProperty("vpc_id", value);
    }

    /// <summary>
    /// The workspace_security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceSecurityGroupId is required")]
    public required TerraformProperty<string> WorkspaceSecurityGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workspace_security_group_id");
        set => SetProperty("workspace_security_group_id", value);
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
