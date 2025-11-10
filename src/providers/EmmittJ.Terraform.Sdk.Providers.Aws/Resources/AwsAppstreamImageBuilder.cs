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
        set => SetProperty("endpoint_type", value);
    }

    /// <summary>
    /// The vpce_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpceId
    {
        set => SetProperty("vpce_id", value);
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
        set => SetProperty("directory_name", value);
    }

    /// <summary>
    /// The organizational_unit_distinguished_name attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationalUnitDistinguishedName
    {
        set => SetProperty("organizational_unit_distinguished_name", value);
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
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        set => SetProperty("subnet_ids", value);
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
        SetOutput("arn");
        SetOutput("created_time");
        SetOutput("state");
        SetOutput("appstream_agent_version");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("enable_default_internet_access");
        SetOutput("iam_role_arn");
        SetOutput("id");
        SetOutput("image_arn");
        SetOutput("image_name");
        SetOutput("instance_type");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The appstream_agent_version attribute.
    /// </summary>
    public TerraformProperty<string> AppstreamAgentVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("appstream_agent_version");
        set => SetProperty("appstream_agent_version", value);
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
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The enable_default_internet_access attribute.
    /// </summary>
    public TerraformProperty<bool> EnableDefaultInternetAccess
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_default_internet_access");
        set => SetProperty("enable_default_internet_access", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> IamRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_role_arn");
        set => SetProperty("iam_role_arn", value);
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
    /// The image_arn attribute.
    /// </summary>
    public TerraformProperty<string> ImageArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image_arn");
        set => SetProperty("image_arn", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    public TerraformProperty<string> ImageName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image_name");
        set => SetProperty("image_name", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_type");
        set => SetProperty("instance_type", value);
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
    /// Block for access_endpoint.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 AccessEndpoint block(s) allowed")]
    public HashSet<AwsAppstreamImageBuilderAccessEndpointBlock>? AccessEndpoint
    {
        set => SetProperty("access_endpoint", value);
    }

    /// <summary>
    /// Block for domain_join_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainJoinInfo block(s) allowed")]
    public List<AwsAppstreamImageBuilderDomainJoinInfoBlock>? DomainJoinInfo
    {
        set => SetProperty("domain_join_info", value);
    }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public List<AwsAppstreamImageBuilderVpcConfigBlock>? VpcConfig
    {
        set => SetProperty("vpc_config", value);
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
