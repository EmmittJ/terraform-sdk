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
        set => SetProperty("data_identifiers", value);
    }

    /// <summary>
    /// The sid attribute.
    /// </summary>
    public TerraformProperty<string>? Sid
    {
        set => SetProperty("sid", value);
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
        SetOutput("json");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("version");
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
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    public List<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceConfigurationBlock>? Configuration
    {
        set => SetProperty("configuration", value);
    }

    /// <summary>
    /// Block for statement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 Statement block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 Statement block(s) allowed")]
    public List<AwsCloudwatchLogDataProtectionPolicyDocumentDataSourceStatementBlock>? Statement
    {
        set => SetProperty("statement", value);
    }

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformExpression Json => this["json"];

}
