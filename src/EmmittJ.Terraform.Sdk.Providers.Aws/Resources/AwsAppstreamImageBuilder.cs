using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_endpoint in .
/// Nesting mode: set
/// </summary>
public class AwsAppstreamImageBuilderAccessEndpointBlock : TerraformBlock
{
    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    public required TerraformProperty<string> EndpointType
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_type");
        set => WithProperty("endpoint_type", value);
    }

    /// <summary>
    /// The vpce_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpceId
    {
        get => GetProperty<TerraformProperty<string>>("vpce_id");
        set => WithProperty("vpce_id", value);
    }

}

/// <summary>
/// Block type for domain_join_info in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamImageBuilderDomainJoinInfoBlock : TerraformBlock
{
    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    public TerraformProperty<string>? DirectoryName
    {
        get => GetProperty<TerraformProperty<string>>("directory_name");
        set => WithProperty("directory_name", value);
    }

    /// <summary>
    /// The organizational_unit_distinguished_name attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationalUnitDistinguishedName
    {
        get => GetProperty<TerraformProperty<string>>("organizational_unit_distinguished_name");
        set => WithProperty("organizational_unit_distinguished_name", value);
    }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamImageBuilderVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => WithProperty("subnet_ids", value);
    }

}

/// <summary>
/// Manages a aws_appstream_image_builder resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppstreamImageBuilder : TerraformResource
{
    public AwsAppstreamImageBuilder(string name) : base("aws_appstream_image_builder", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_time");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The appstream_agent_version attribute.
    /// </summary>
    public TerraformProperty<string>? AppstreamAgentVersion
    {
        get => GetProperty<TerraformProperty<string>>("appstream_agent_version");
        set => this.WithProperty("appstream_agent_version", value);
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
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The enable_default_internet_access attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableDefaultInternetAccess
    {
        get => GetProperty<TerraformProperty<bool>>("enable_default_internet_access");
        set => this.WithProperty("enable_default_internet_access", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? IamRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("iam_role_arn");
        set => this.WithProperty("iam_role_arn", value);
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
    /// The image_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ImageArn
    {
        get => GetProperty<TerraformProperty<string>>("image_arn");
        set => this.WithProperty("image_arn", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    public TerraformProperty<string>? ImageName
    {
        get => GetProperty<TerraformProperty<string>>("image_name");
        set => this.WithProperty("image_name", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
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
    /// Block for access_endpoint.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 AccessEndpoint block(s) allowed")]
    public HashSet<AwsAppstreamImageBuilderAccessEndpointBlock>? AccessEndpoint
    {
        get => GetProperty<HashSet<AwsAppstreamImageBuilderAccessEndpointBlock>>("access_endpoint");
        set => this.WithProperty("access_endpoint", value);
    }

    /// <summary>
    /// Block for domain_join_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainJoinInfo block(s) allowed")]
    public List<AwsAppstreamImageBuilderDomainJoinInfoBlock>? DomainJoinInfo
    {
        get => GetProperty<List<AwsAppstreamImageBuilderDomainJoinInfoBlock>>("domain_join_info");
        set => this.WithProperty("domain_join_info", value);
    }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public List<AwsAppstreamImageBuilderVpcConfigBlock>? VpcConfig
    {
        get => GetProperty<List<AwsAppstreamImageBuilderVpcConfigBlock>>("vpc_config");
        set => this.WithProperty("vpc_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
