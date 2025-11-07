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
        this.DeclareOutput("arn");
        this.DeclareOutput("url");
    }

    /// <summary>
    /// The auth_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AuthMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auth_mode");
        set => this.WithProperty("auth_mode", value);
    }

    /// <summary>
    /// The default_s3_location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultS3Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_s3_location");
        set => this.WithProperty("default_s3_location", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The encryption_key_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EncryptionKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encryption_key_arn");
        set => this.WithProperty("encryption_key_arn", value);
    }

    /// <summary>
    /// The engine_security_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EngineSecurityGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_security_group_id");
        set => this.WithProperty("engine_security_group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The idp_auth_url attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IdpAuthUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("idp_auth_url");
        set => this.WithProperty("idp_auth_url", value);
    }

    /// <summary>
    /// The idp_relay_state_parameter_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IdpRelayStateParameterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("idp_relay_state_parameter_name");
        set => this.WithProperty("idp_relay_state_parameter_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_role");
        set => this.WithProperty("service_role", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SubnetIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The user_role attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UserRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_role");
        set => this.WithProperty("user_role", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

    /// <summary>
    /// The workspace_security_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkspaceSecurityGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_security_group_id");
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
