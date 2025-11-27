using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dynamodb_tables Terraform data source.
/// Retrieves information about a aws_dynamodb_tables.
/// </summary>
public partial class AwsDynamodbTablesDataSource(string name) : TerraformDataSource("aws_dynamodb_tables", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The names attribute.
    /// </summary>
    public TerraformList<string> Names
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "names").ResolveNodes(ctx));
    }

}
