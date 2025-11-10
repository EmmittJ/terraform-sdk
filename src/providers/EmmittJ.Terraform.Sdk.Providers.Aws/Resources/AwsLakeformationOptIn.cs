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
        get => GetProperty<TerraformProperty<string>>("expression");
        set => WithProperty("expression", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("data_lake_principal_identifier");
        set => WithProperty("data_lake_principal_identifier", value);
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
        this.WithOutput("last_modified");
        this.WithOutput("last_updated_by");
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
    /// Block for condition.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLakeformationOptInConditionBlock>? Condition
    {
        get => GetProperty<List<AwsLakeformationOptInConditionBlock>>("condition");
        set => this.WithProperty("condition", value);
    }

    /// <summary>
    /// Block for principal.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLakeformationOptInPrincipalBlock>? Principal
    {
        get => GetProperty<List<AwsLakeformationOptInPrincipalBlock>>("principal");
        set => this.WithProperty("principal", value);
    }

    /// <summary>
    /// Block for resource_data.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLakeformationOptInResourceDataBlock>? ResourceData
    {
        get => GetProperty<List<AwsLakeformationOptInResourceDataBlock>>("resource_data");
        set => this.WithProperty("resource_data", value);
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
