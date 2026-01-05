// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

namespace SqlProcessorDemo;

public readonly struct SqlStatementInfo(string sanitizedSql, string dbQuerySummaryText)
{
    public string SanitizedSql { get; } = sanitizedSql;
    public string DbQuerySummary { get; } = dbQuerySummaryText;
}
