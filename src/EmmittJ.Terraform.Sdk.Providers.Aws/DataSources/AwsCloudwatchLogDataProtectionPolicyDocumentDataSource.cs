using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for statement in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlock : TerraformBlock
{
    /// <summary>
    /// The data_identifiers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataIdentifiers is required")]
    public HashSet<TerraformProperty<string>>? DataIdentifiers
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("data_identifiers");
        set => WithProperty("data_identifiers", value);
    }

    /// <summary>
    /// The sid attribute.
    /// </summary>
    public TerraformProperty<string>? Sid
    {
        get => GetProperty<TerraformProperty<string>>("sid");
        set => WithProperty("sid", value);
    }

}

/// <summary>
/// Retrieves information about a aws_cloudwatch_log_data_protection_policy_document.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudwatchLogDataProtectionPolicyDocumentDataSource : TerraformDataSource
{
    public AwsCloudwatchLogDataProtectionPolicyDocumentDataSource(string name) : base("aws_cloudwatch_log_data_protection_policy_document", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("json");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    public List<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceConfigurationBlock>? Configuration
    {
        get => GetProperty<List<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceConfigurationBlock>>("configuration");
        set => this.WithProperty("configuration", value);
    }

    /// <summary>
    /// Block for statement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 Statement block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 Statement block(s) allowed")]
    public List<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlock>? Statement
    {
        get => GetProperty<List<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlock>>("statement");
        set => this.WithProperty("statement", value);
    }

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformExpression Json => this["json"];

}
