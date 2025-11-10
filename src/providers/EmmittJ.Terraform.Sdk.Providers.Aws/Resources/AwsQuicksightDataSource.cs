using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for credentials in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceCredentialsBlock : ITerraformBlock
{
    /// <summary>
    /// The copy_source_arn attribute.
    /// </summary>
    [TerraformPropertyName("copy_source_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CopySourceArn { get; set; }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    [TerraformPropertyName("secret_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecretArn { get; set; }

}

/// <summary>
/// Block type for parameters in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceParametersBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for permission in .
/// Nesting mode: set
/// </summary>
public class AwsQuicksightDataSourcePermissionBlock : ITerraformBlock
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    [TerraformPropertyName("actions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Actions { get; set; }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    [TerraformPropertyName("principal")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Principal { get; set; }

}

/// <summary>
/// Block type for ssl_properties in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceSslPropertiesBlock : ITerraformBlock
{
    /// <summary>
    /// The disable_ssl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisableSsl is required")]
    [TerraformPropertyName("disable_ssl")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> DisableSsl { get; set; }

}

/// <summary>
/// Block type for vpc_connection_properties in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSourceVpcConnectionPropertiesBlock : ITerraformBlock
{
    /// <summary>
    /// The vpc_connection_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcConnectionArn is required")]
    [TerraformPropertyName("vpc_connection_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VpcConnectionArn { get; set; }

}

/// <summary>
/// Manages a aws_quicksight_data_source resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsQuicksightDataSource : TerraformResource
{
    public AwsQuicksightDataSource(string name) : base("aws_quicksight_data_source", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformPropertyName("aws_account_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AwsAccountId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "aws_account_id");

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceId is required")]
    [TerraformPropertyName("data_source_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataSourceId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// Block for credentials.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Credentials block(s) allowed")]
    [TerraformPropertyName("credentials")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSourceCredentialsBlock>>? Credentials { get; set; } = new();

    /// <summary>
    /// Block for parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Parameters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Parameters block(s) allowed")]
    [TerraformPropertyName("parameters")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSourceParametersBlock>>? Parameters { get; set; } = new();

    /// <summary>
    /// Block for permission.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(64, ErrorMessage = "Maximum 64 Permission block(s) allowed")]
    [TerraformPropertyName("permission")]
    public TerraformSet<TerraformBlock<AwsQuicksightDataSourcePermissionBlock>>? Permission { get; set; } = new();

    /// <summary>
    /// Block for ssl_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslProperties block(s) allowed")]
    [TerraformPropertyName("ssl_properties")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSourceSslPropertiesBlock>>? SslProperties { get; set; } = new();

    /// <summary>
    /// Block for vpc_connection_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConnectionProperties block(s) allowed")]
    [TerraformPropertyName("vpc_connection_properties")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSourceVpcConnectionPropertiesBlock>>? VpcConnectionProperties { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
