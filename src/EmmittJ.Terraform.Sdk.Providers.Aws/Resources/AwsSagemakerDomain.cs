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
    public TerraformProperty<string>? AppNetworkAccessType
    {
        get => GetProperty<TerraformProperty<string>>("app_network_access_type");
        set => this.WithProperty("app_network_access_type", value);
    }

    /// <summary>
    /// The app_security_group_management attribute.
    /// </summary>
    public TerraformProperty<string>? AppSecurityGroupManagement
    {
        get => GetProperty<TerraformProperty<string>>("app_security_group_management");
        set => this.WithProperty("app_security_group_management", value);
    }

    /// <summary>
    /// The auth_mode attribute.
    /// </summary>
    public TerraformProperty<string>? AuthMode
    {
        get => GetProperty<TerraformProperty<string>>("auth_mode");
        set => this.WithProperty("auth_mode", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformProperty<string>? DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
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
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SubnetIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tag_propagation attribute.
    /// </summary>
    public TerraformProperty<string>? TagPropagation
    {
        get => GetProperty<TerraformProperty<string>>("tag_propagation");
        set => this.WithProperty("tag_propagation", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
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
