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
    public string? AuthMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auth_mode")?.Value;
        set => this.WithProperty("auth_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_s3_location attribute.
    /// </summary>
    public string? DefaultS3Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_s3_location")?.Value;
        set => this.WithProperty("default_s3_location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The encryption_key_arn attribute.
    /// </summary>
    public string? EncryptionKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encryption_key_arn")?.Value;
        set => this.WithProperty("encryption_key_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The engine_security_group_id attribute.
    /// </summary>
    public string? EngineSecurityGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_security_group_id")?.Value;
        set => this.WithProperty("engine_security_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The idp_auth_url attribute.
    /// </summary>
    public string? IdpAuthUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("idp_auth_url")?.Value;
        set => this.WithProperty("idp_auth_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The idp_relay_state_parameter_name attribute.
    /// </summary>
    public string? IdpRelayStateParameterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("idp_relay_state_parameter_name")?.Value;
        set => this.WithProperty("idp_relay_state_parameter_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    public string? ServiceRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_role")?.Value;
        set => this.WithProperty("service_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<string>? SubnetIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("subnet_ids")?.Value;
        set => this.WithProperty("subnet_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The user_role attribute.
    /// </summary>
    public string? UserRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_role")?.Value;
        set => this.WithProperty("user_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public string? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id")?.Value;
        set => this.WithProperty("vpc_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workspace_security_group_id attribute.
    /// </summary>
    public string? WorkspaceSecurityGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_security_group_id")?.Value;
        set => this.WithProperty("workspace_security_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
