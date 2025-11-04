using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_domain resource.
/// </summary>
public class AwsSagemakerDomain : TerraformResource
{
    public AwsSagemakerDomain(string name) : base("aws_sagemaker_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("home_efs_file_system_id");
        this.DeclareOutput("security_group_id_for_domain_boundary");
        this.DeclareOutput("single_sign_on_application_arn");
        this.DeclareOutput("single_sign_on_managed_application_instance_id");
        this.DeclareOutput("url");
    }

    /// <summary>
    /// The app_network_access_type attribute.
    /// </summary>
    public string? AppNetworkAccessType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_network_access_type")?.Value;
        set => this.WithProperty("app_network_access_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The app_security_group_management attribute.
    /// </summary>
    public string? AppSecurityGroupManagement
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_security_group_management")?.Value;
        set => this.WithProperty("app_security_group_management", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The domain_name attribute.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name")?.Value;
        set => this.WithProperty("domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<string>? SubnetIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("subnet_ids")?.Value;
        set => this.WithProperty("subnet_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tag_propagation attribute.
    /// </summary>
    public string? TagPropagation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tag_propagation")?.Value;
        set => this.WithProperty("tag_propagation", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The vpc_id attribute.
    /// </summary>
    public string? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id")?.Value;
        set => this.WithProperty("vpc_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The home_efs_file_system_id attribute.
    /// </summary>
    public TerraformExpression HomeEfsFileSystemId => this["home_efs_file_system_id"];

    /// <summary>
    /// The security_group_id_for_domain_boundary attribute.
    /// </summary>
    public TerraformExpression SecurityGroupIdForDomainBoundary => this["security_group_id_for_domain_boundary"];

    /// <summary>
    /// The single_sign_on_application_arn attribute.
    /// </summary>
    public TerraformExpression SingleSignOnApplicationArn => this["single_sign_on_application_arn"];

    /// <summary>
    /// The single_sign_on_managed_application_instance_id attribute.
    /// </summary>
    public TerraformExpression SingleSignOnManagedApplicationInstanceId => this["single_sign_on_managed_application_instance_id"];

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
