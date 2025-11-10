using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for condition in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationOptInConditionBlock : TerraformBlock
{
    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformProperty<string>? Expression
    {
        set => SetProperty("expression", value);
    }

}

/// <summary>
/// Block type for principal in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationOptInPrincipalBlock : TerraformBlock
{
    /// <summary>
    /// The data_lake_principal_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataLakePrincipalIdentifier is required")]
    public required TerraformProperty<string> DataLakePrincipalIdentifier
    {
        set => SetProperty("data_lake_principal_identifier", value);
    }

}

/// <summary>
/// Block type for resource_data in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationOptInResourceDataBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_lakeformation_opt_in resource.
/// </summary>
public class AwsLakeformationOptIn : TerraformResource
{
    public AwsLakeformationOptIn(string name) : base("aws_lakeformation_opt_in", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("last_modified");
        SetOutput("last_updated_by");
        SetOutput("region");
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
    /// Block for condition.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLakeformationOptInConditionBlock>? Condition
    {
        set => SetProperty("condition", value);
    }

    /// <summary>
    /// Block for principal.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLakeformationOptInPrincipalBlock>? Principal
    {
        set => SetProperty("principal", value);
    }

    /// <summary>
    /// Block for resource_data.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLakeformationOptInResourceDataBlock>? ResourceData
    {
        set => SetProperty("resource_data", value);
    }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformExpression LastModified => this["last_modified"];

    /// <summary>
    /// The last_updated_by attribute.
    /// </summary>
    public TerraformExpression LastUpdatedBy => this["last_updated_by"];

}
