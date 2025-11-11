using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for credentials in .
/// Nesting mode: list
/// </summary>
public partial class AwsQuicksightDataSourceCredentialsBlock : TerraformBlockBase
{
    /// <summary>
    /// The copy_source_arn attribute.
    /// </summary>
    [TerraformProperty("copy_source_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CopySourceArn { get; set; }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    [TerraformProperty("secret_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SecretArn { get; set; }

}

/// <summary>
/// Block type for parameters in .
/// Nesting mode: list
/// </summary>
public partial class AwsQuicksightDataSourceParametersBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for permission in .
/// Nesting mode: set
/// </summary>
public partial class AwsQuicksightDataSourcePermissionBlock : TerraformBlockBase
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    [TerraformProperty("actions")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Actions { get; set; }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    [TerraformProperty("principal")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Principal { get; set; }

}

/// <summary>
/// Block type for ssl_properties in .
/// Nesting mode: list
/// </summary>
public partial class AwsQuicksightDataSourceSslPropertiesBlock : TerraformBlockBase
{
    /// <summary>
    /// The disable_ssl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisableSsl is required")]
    [TerraformProperty("disable_ssl")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> DisableSsl { get; set; }

}

/// <summary>
/// Block type for vpc_connection_properties in .
/// Nesting mode: list
/// </summary>
public partial class AwsQuicksightDataSourceVpcConnectionPropertiesBlock : TerraformBlockBase
{
    /// <summary>
    /// The vpc_connection_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcConnectionArn is required")]
    [TerraformProperty("vpc_connection_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VpcConnectionArn { get; set; }

}

/// <summary>
/// Manages a aws_quicksight_data_source resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsQuicksightDataSource : TerraformResource
{
    public AwsQuicksightDataSource(string name) : base("aws_quicksight_data_source", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformProperty("aws_account_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AwsAccountId { get; set; }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceId is required")]
    [TerraformProperty("data_source_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DataSourceId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for credentials.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Credentials block(s) allowed")]
    [TerraformProperty("credentials")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSourceCredentialsBlock>>? Credentials { get; set; }

    /// <summary>
    /// Block for parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Parameters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Parameters block(s) allowed")]
    [TerraformProperty("parameters")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSourceParametersBlock>>? Parameters { get; set; }

    /// <summary>
    /// Block for permission.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(64, ErrorMessage = "Maximum 64 Permission block(s) allowed")]
    [TerraformProperty("permission")]
    public TerraformSet<TerraformBlock<AwsQuicksightDataSourcePermissionBlock>>? Permission { get; set; }

    /// <summary>
    /// Block for ssl_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslProperties block(s) allowed")]
    [TerraformProperty("ssl_properties")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSourceSslPropertiesBlock>>? SslProperties { get; set; }

    /// <summary>
    /// Block for vpc_connection_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConnectionProperties block(s) allowed")]
    [TerraformProperty("vpc_connection_properties")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSourceVpcConnectionPropertiesBlock>>? VpcConnectionProperties { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
