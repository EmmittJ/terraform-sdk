using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for credentials in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// The copy_source_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CopySourceArn
    {
        set => SetProperty("copy_source_arn", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SecretArn
    {
        set => SetProperty("secret_arn", value);
    }

}

/// <summary>
/// Block type for parameters in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlock : TerraformBlock
{
}

/// <summary>
/// Block type for permission in .
/// Nesting mode: set
/// </summary>
public class AwsQuicksightDataSourcePermissionBlock : TerraformBlock
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    public HashSet<TerraformProperty<string>>? Actions
    {
        set => SetProperty("actions", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformProperty<string> Principal
    {
        set => SetProperty("principal", value);
    }

}

/// <summary>
/// Block type for ssl_properties in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceSslPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// The disable_ssl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisableSsl is required")]
    public required TerraformProperty<bool> DisableSsl
    {
        set => SetProperty("disable_ssl", value);
    }

}

/// <summary>
/// Block type for vpc_connection_properties in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceVpcConnectionPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// The vpc_connection_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcConnectionArn is required")]
    public required TerraformProperty<string> VpcConnectionArn
    {
        set => SetProperty("vpc_connection_arn", value);
    }

}

/// <summary>
/// Manages a aws_quicksight_data_source resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsQuicksightDataSource : TerraformResource
{
    public AwsQuicksightDataSource(string name) : base("aws_quicksight_data_source", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("aws_account_id");
        SetOutput("data_source_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("type");
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string> AwsAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aws_account_id");
        set => SetProperty("aws_account_id", value);
    }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceId is required")]
    public required TerraformProperty<string> DataSourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_source_id");
        set => SetProperty("data_source_id", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for credentials.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Credentials block(s) allowed")]
    public List<AwsQuicksightDataSourceCredentialsBlock>? Credentials
    {
        set => SetProperty("credentials", value);
    }

    /// <summary>
    /// Block for parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Parameters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Parameters block(s) allowed")]
    public List<AwsQuicksightDataSourceParametersBlock>? Parameters
    {
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// Block for permission.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(64, ErrorMessage = "Maximum 64 Permission block(s) allowed")]
    public HashSet<AwsQuicksightDataSourcePermissionBlock>? Permission
    {
        set => SetProperty("permission", value);
    }

    /// <summary>
    /// Block for ssl_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslProperties block(s) allowed")]
    public List<AwsQuicksightDataSourceSslPropertiesBlock>? SslProperties
    {
        set => SetProperty("ssl_properties", value);
    }

    /// <summary>
    /// Block for vpc_connection_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConnectionProperties block(s) allowed")]
    public List<AwsQuicksightDataSourceVpcConnectionPropertiesBlock>? VpcConnectionProperties
    {
        set => SetProperty("vpc_connection_properties", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
